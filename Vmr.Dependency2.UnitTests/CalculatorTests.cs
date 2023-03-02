namespace Vmr.Dependency2.UnitTests
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void Calculator_Multiply()
        {
            // Arrange
            var arg1 = 2;
            var arg2 = 2;
            var expectedResult = 4;

            // Act
            var calculator = new ExtendedCalculator();
            var result = calculator.Multiply(arg1, arg2);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }
    }
}