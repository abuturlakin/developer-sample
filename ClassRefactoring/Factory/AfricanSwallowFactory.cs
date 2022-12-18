using DeveloperSample.ClassRefactoring.Models;

namespace DeveloperSample.ClassRefactoring.Factory
{
    public class AfricanSwallowFactory : SwallowFactory
    {
        public override Swallow GetSwallow()
        {
            return new AfricanSwallow();
        }
    }    
}
