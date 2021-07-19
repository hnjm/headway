﻿using Headway.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Headway.Core.Helpers
{
    public static class TypeAttributeHelper
    {
        public static IEnumerable<string> GetEntryAssemblyTypeNamesByAttribute(Type attributeType)
        {
            var assembly = Assembly.GetEntryAssembly();
            var types = (from t in assembly.GetTypes()
                         let attributes = t.GetCustomAttributes(attributeType, true)
                         where attributes != null && attributes.Length > 0
                         select t.Name).ToList();
            return types;
        }

        public static IEnumerable<DynamicType> GetHeadwayTypesByAttribute(Type attributeType)
        {
            var dynamicTypes = new List<DynamicType>();

            var assemblies = AppDomain.CurrentDomain.GetAssemblies()
                .Where(a => a.GetName().Name.StartsWith("Headway"))
                .ToList();

            foreach (var assembly in assemblies)
            {
                var types = (from t in assembly.GetTypes()
                                    let attributes = t.GetCustomAttributes(attributeType, true)
                                    where attributes != null && attributes.Length > 0
                                    select new DynamicType
                                    {
                                        Name = GetName(t),
                                        DisplayName = GetName(t),
                                        Namespace = GetFullNamespace(t, assembly)
                                    }).ToList();

                dynamicTypes.AddRange(types);
            }

            return dynamicTypes;
        }

        private static string GetName(Type type)
        {
            return (type.IsAbstract && type.Name.Contains("Base"))
                ? type.Name.Replace("Base", string.Empty)
                : type.Name;
        }

        private static string GetFullNamespace(Type type, Assembly assembly)
        {
            return (type.IsAbstract && type.Name.Contains("Base"))
                ? $"{type.FullName.Replace("Base", string.Empty)}, {assembly.GetName().Name}"
                : $"{type.Name}, {assembly.GetName().Name}";
        }
    }
}
