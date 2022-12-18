using DeveloperSample.ClassRefactoring.Enums;

namespace DeveloperSample.ClassRefactoring.Models;

public class AfricanSwallow : Swallow
{
    public AfricanSwallow() : base(SwallowType.African) {}

    public override double GetAirspeedVelocity()
    {
        return Load switch
        {
            SwallowLoad.None => 22,
            SwallowLoad.Coconut => 18,
            _ => base.GetAirspeedVelocity()
        };
    }
}