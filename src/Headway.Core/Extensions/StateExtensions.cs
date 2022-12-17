﻿using Headway.Core.Enums;
using Headway.Core.Model;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Headway.Core.Extensions
{
    public static class StateExtensions
    {
        public static async Task InitialiseAsync(this State state, object arg)
        {
            var subStatePosition = state.SubStates.Min(s => s.Position);

            var subState = state.SubStates.First(s => s.Position.Equals(subStatePosition));

            await subState.InitialiseAsync(arg).ConfigureAwait(false);

            await state.ExecuteActionsAsync(arg, StateActionType.Initialize).ConfigureAwait(false);

            state.StateStatus = StateStatus.InProgress;
        }

        public static async Task CompleteAsync(this State state, object arg)
        {
            await state.ExecuteActionsAsync(arg, StateActionType.Complete).ConfigureAwait(false);

            state.StateStatus = StateStatus.Completed;
        }

        public static async Task ResestAsync(this State state, object arg)
        {
            await state.ExecuteActionsAsync(arg, StateActionType.Reset).ConfigureAwait(false);

            state.StateStatus = StateStatus.NotStarted;
        }

        public static List<State> GetStates(this Dictionary<string, State> dictionary, List<string> stateCodes)
        {
            var states = new List<State>();

            foreach (var stateCode in stateCodes)
            {
                states.Add(dictionary[stateCode]);
            }

            return states;
        }
    }
}