using System;
using Xunit;
using myApi.Controllers;

namespace testApi
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(20,new int[] { 2,3,4,5,6 })]
        [InlineData(1000,new int[] { 198,199,200,201,202 })]
        [InlineData(16,new int[] { })]
        public void Test1(double number, int[] expected )
        {
            var calculate = new Calc();
            var result = calculate.calc(number);
            Assert.Equal(expected,result);
        }
    }
}
