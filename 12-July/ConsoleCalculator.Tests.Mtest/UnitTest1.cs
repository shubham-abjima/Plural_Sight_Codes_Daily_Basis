using _12_July;

namespace ConsoleCalculator.Tests.Mtest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ThrowWhenUnsupportedOperation()
        {
            var sut = new Calculator();

            Assert.ThrowsException<CalculationOperationNotSupportedException>(
                () => sut.Calculate(1, 1, "+"));

            var ex = Assert.ThrowsException<_12_July.CalculationOperationNotSupportedException>(() => sut.Calculate(1, 1, "+"));

            Assert.AreEqual("+", ex.operation);
        }
    }
}