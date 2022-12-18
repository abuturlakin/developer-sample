using System;

using DeveloperSample.ClassRefactoring.Enums;
using DeveloperSample.ClassRefactoring.Models;

namespace DeveloperSample.ClassRefactoring.Factory
{
    public abstract class SwallowFactory : ISwallowFactory
    {
        public abstract Swallow GetSwallow();

        public static ISwallowFactory CreateInstance(SwallowType swallowType)
        {
            return swallowType switch
            {
                SwallowType.African => new AfricanSwallowFactory(),
                SwallowType.European => new EuropianSwallowFactory(),
                _ => throw new NotSupportedException("Factory type is not supported")
            };
        }
    }    
}

