using DeveloperSample.ClassRefactoring.Enums;

namespace DeveloperSample.ClassRefactoring.Models;

public class EuropeanSwallow : Swallow
{
    public EuropeanSwallow() : base(SwallowType.European) {}
        
    public override double GetAirspeedVelocity()
    {
        return Load switch
        {
            SwallowLoad.None => 20,
            SwallowLoad.Coconut => 16,
            _ => base.GetAirspeedVelocity()
        };
    }        
}