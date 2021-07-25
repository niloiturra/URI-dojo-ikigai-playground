using FluentAssertions;
using Xunit;

namespace URI_dojo
{
    //URI 1000
    public class HelloWorld
    {
        private string Print()
        {
            return "Hello World!";
        }
        
        [Fact]
        public void Should_print_hello_world_in_screen()
        {
            //act
            var result = Print();

            //assert
            result.Should().Be("Hello World!");
        }
    }
}