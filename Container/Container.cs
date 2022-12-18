using System;
using System.Collections.Generic;

namespace DeveloperSample.Container
{
    public class Container
    {
        private static readonly Lazy<Dictionary<Type, Type>> Configuration = new();

        public void Register<TInterface, TImplementation>()
            where TImplementation : TInterface
        {
            Configuration.Value.Add(typeof(TInterface), typeof(TImplementation));
        }
        
        public T Resolve<T>()
        {
            var implementationType = Configuration.Value[typeof(T)];
            return (T) Activator.CreateInstance(implementationType);
        }
    }
}