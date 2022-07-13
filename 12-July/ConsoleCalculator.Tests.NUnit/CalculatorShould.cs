namespace ConsoleCalculator.Tests.NUnit
{
    public class CalculatorShould
    {
        [Test]
        public void ThrowWhenUnsupportedOperation()
        {
            var sut = new _12_July.Calculator();

            Assert.That(() => sut.Calculate(10, 2, "+"),
                Throws.TypeOf<_12_July.CalculationOperationNotSupportedException>());

            Assert.That(() => sut.Calculate(10, 1, "+"),
                Throws.TypeOf<_12_July.CalculationOperationNotSupportedException>()
                .With
                .Property("operation").EqualTo("+"));
            
            var ex =  Assert.Throws<_12_July.CalculationOperationNotSupportedException>(() => sut.Calculate(1,1,"+"));
            Assert.That(ex.operation, Is.EqualTo("+"));

            //Assert.That(() => sut.Calculate(1, 1, "+"),
            //    Throws.TypeOf<_12_July.CalculationException>());
            Assert.That(() => sut.Calculate(1, 1, "+"),
                Throws.InstanceOf<_12_July.CalculationException>());
        }


    }
}