using System;

using DeveloperSample.ClassRefactoring.Enums;

namespace DeveloperSample.ClassRefactoring.Models;

public abstract class Swallow
{
    public SwallowType Type { get; }
        
    public SwallowLoad Load { get; private set; }

    public Swallow(SwallowType swallowType)
    {
        Type = swallowType;
    }

    public void ApplyLoad(SwallowLoad load)
    {
        Load = load;
    }

    public virtual double GetAirspeedVelocity()
    {
        throw new InvalidOperationException();
    }
}