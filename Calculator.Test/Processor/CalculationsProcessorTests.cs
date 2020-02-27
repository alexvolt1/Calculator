using System;
using Xunit;

namespace Calculator.Processor
{
    public class CalculationsProcessorTests
    {
        private readonly ICalculationsProcessor _processor;
        public CalculationsProcessorTests()
        {
            _processor = new CalculationsProcessor();
        }
        [Fact]
        public void ShouldAddNumbers()
        {
            double result = 2;
            string inputString = "2";
            int i = 0;
            Assert.Equal(_processor.AddMethod(inputString, i), result);
        }
        [Fact]
        public void ShouldSubtractNumbers()
        {
            double result = 2;
            string inputString = "2";
            int i = 0;
            Assert.Equal(_processor.SubtractMethod(inputString, i), result);
        }
        [Fact]
        public void ShouldMultiplyNumbers()
        {
            double result = 2;
            string inputString = "2";
            int i = 0;
            Assert.Equal(_processor.MultiMethod(inputString, i), result);
        }
        [Fact]
        public void ShouldDivideNumbers()
        {
            double result = 2;
            string inputString = "2";
            int i = 0;
            Assert.Equal(_processor.DivMethod(inputString, i), result);
        }

        [Fact]
        public void ShouldThrowExceptionIfInputIsNull()
        {
            ArgumentNullException exception;
            exception = Assert.Throws<ArgumentNullException>(() => _processor.AddMethod(null, 0));
            Assert.Equal("inputString", exception.ParamName);

            exception = Assert.Throws<ArgumentNullException>(() => _processor.SubtractMethod(null, 0));
            Assert.Equal("inputString", exception.ParamName);

            exception = Assert.Throws<ArgumentNullException>(() => _processor.MultiMethod(null, 0));
            Assert.Equal("inputString", exception.ParamName);

            exception = Assert.Throws<ArgumentNullException>(() => _processor.DivMethod(null, 0));
            Assert.Equal("inputString", exception.ParamName);
        }
    }
}
