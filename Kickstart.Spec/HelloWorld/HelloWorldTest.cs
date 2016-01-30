using Concordion.NET.Integration;
using Kickstart.Example;

namespace Kickstart.Spec.HelloWorld
{
    [ConcordionTest]
    public class HelloWorldTest
    {
        private readonly Greeter m_HelloWorldGreeter = new Greeter();

        public string GetGreeting()
        {
            return this.m_HelloWorldGreeter.GetMessage();
        }
    }
}
