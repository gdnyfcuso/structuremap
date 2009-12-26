using System;
using StructureMap.Construction;
using StructureMap.Graph;
using StructureMap.Pipeline;
using StructureMap.Testing.Widget;

namespace StructureMap.Testing.Pipeline
{
    public class StubBuildSession : BuildSession
    {
        public StubBuildSession() : base(new PluginGraph())
        {
        }

        public new BuildStack BuildStack
        {
            get
            {
                var stack = new BuildStack();
                stack.Push(new BuildFrame(typeof (Rule), "Blue", typeof (ColorRule)));
                return stack;
            }
        }


        public InstanceBuilder FindBuilderByConcreteKey(Type pluginType, string concreteKey)
        {
            throw new NotImplementedException();
        }


        public object CreateInstance(string typeName, IConfiguredInstance instance)
        {
            throw new NotImplementedException();
        }

        public object CreateInstance(string typeName)
        {
            throw new NotImplementedException();
        }

        public object CreateInstance(Type pluginType, IConfiguredInstance instance)
        {
            throw new NotImplementedException();
        }

        public InstanceBuilder FindInstanceBuilder(Type pluginType, string concreteKey)
        {
            throw new NotImplementedException();
        }

        public InstanceBuilder FindInstanceBuilder(Type pluginType, Type pluggedType)
        {
            throw new NotImplementedException();
        }
    }
}