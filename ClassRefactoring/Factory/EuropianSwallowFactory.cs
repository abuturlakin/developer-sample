using DeveloperSample.ClassRefactoring.Models;

namespace DeveloperSample.ClassRefactoring.Factory
{
    public class EuropianSwallowFactory : SwallowFactory
    {
        public override Swallow GetSwallow()
        {
            return new EuropeanSwallow();
        }
    }
}