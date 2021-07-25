using FluentAssertions;
using Xunit;

namespace URI_dojo
{
    //URI 1001
    public class ExtremelyBasic
    {
        private int Sum(int firstNum, int secondNum)
        {
            return firstNum + secondNum;
        }
        
        [Theory]
        [InlineData(10, 9, 19)]
        [InlineData(-10, 4, -6)]
        [InlineData(15, -7, 8)]
        public void Should_sum_numbers(int firstNum, int secondNum, int expected)
        {
            //arrange & act
            var result = Sum(firstNum, secondNum);

            //assert
            result.Should().Be(expected);
        }
    }
}