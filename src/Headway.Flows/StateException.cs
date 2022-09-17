﻿using System;

namespace Headway.Flows
{
    public class StateException : Exception
    {
        public StateException(State state, string message = "", Exception? innerException = null)
            : base(message, innerException)
        {
            State = state;
        }

        public State State { get; private set; }
    }
}
