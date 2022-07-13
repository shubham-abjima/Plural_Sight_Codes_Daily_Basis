using _12_July;

namespace ConsoleCalculator.Tests.xUnit
{
    public class UnitTest1
    {
        [Fact]
        public void ThrowWhenUnsupportedOperation()
        {
            var sut = new _12_July.Calculator();

            Assert.Throws<CalculationOperationNotSupportedException>(() => sut.Calculate(10, 2, "+"));

            Assert.ThrowsAny<CalculationException>(() => sut.Calculate(1, 1, "+"));


            var ex = Assert.ThrowsAny<_12_July.CalculationOperationNotSupportedException>(() => sut.Calculate(1, 1, "+"));

            Assert.Equal("+", ex.operation);
        }
    } 
}