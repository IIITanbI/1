﻿namespace QA.TestLibs
{
    using Exceptions;
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Reflection;
    using System.Text;
    using System.Threading.Tasks;
    using XmlDesiarilization;

    public static class ReflectionManager
    {
        private static Dictionary<Type, XmlType> _type_xmlType = new Dictionary<Type, XmlType>();
        private static Dictionary<XmlType, List<XmlType>> _xmlType_assignableXmlTypes = new Dictionary<XmlType, List<XmlType>>();
        private static List<string> _loadedAssemblies = new List<string>();

        public static List<XmlType> GetAssignableTypes(Type type)
        {
            var xmlType = GetXmlType(type);
            if (xmlType == null) return new List<XmlType>();

            return _xmlType_assignableXmlTypes[xmlType];
        }

        public static bool IsTypeXml(Type type)
        {
            return _type_xmlType.ContainsKey(type);
        }

        public static XmlType GetXmlType(Type type)
        {
            if (_type_xmlType.ContainsKey(type))
                return _type_xmlType[type];
            return null;
        }

        public static void LoadAssemblies(string pathToLibFolder = null)
        {
            var assemblies = new List<Assembly>();

            assemblies.AddRange(AppDomain.CurrentDomain.GetAssemblies().ToList());

            if (pathToLibFolder != null && Directory.Exists(pathToLibFolder))
            {
                var assemblyFiles = Directory.GetFiles(pathToLibFolder, "*.dll").ToList();
                assemblyFiles.ForEach(af => assemblies.Add(Assembly.LoadFrom(af)));
            }

            var loadedAssemblies = new List<Assembly>();

            foreach (var assembly in assemblies)
            {
                LoadAssembly(assembly);
            }
        }

        public static void LoadAssembly(Assembly assembly)
        {
            var assemblyName = assembly.GetName().Name;
            if (_loadedAssemblies.Contains(assemblyName))
                return;

            var types = assembly.DefinedTypes.ToList();

            foreach (var type in types)
            {
                LoadType(type);
            }

            _loadedAssemblies.Add(assemblyName);
        }

        public static void LoadType(Type type)
        {
            if (typeof(XmlBaseType).IsAssignableFrom(type))
            {
                var xmlType = new XmlType(type);
                if (_type_xmlType.ContainsKey(type))
                    throw new TestLibsException($"Found duped xmlType for type: {type}");

                _type_xmlType.Add(type, xmlType);

                _xmlType_assignableXmlTypes.Add(xmlType, new List<XmlType>());

                foreach (var key in _xmlType_assignableXmlTypes.Keys)
                {
                    if (key.XType.IsAssignableFrom(type))
                    {
                        _xmlType_assignableXmlTypes[key].Add(xmlType);
                    }
                }
            }
        }
    }
}
