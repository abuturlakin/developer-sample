using Xunit;

namespace DeveloperSample.Container
{
    internal interface IContainerTestInterface {}

    internal class ContainerTestClass : IContainerTestInterface {}

    public class ContainerTest
    {
        [Fact]
        public void CanBindAndGetService()
        {
            var container = new Container();
            container.Register<IContainerTestInterface, ContainerTestClass>();
            var testInstance = container.Resolve<IContainerTestInterface>();
            Assert.IsType<ContainerTestClass>(testInstance);
        }
    }
}