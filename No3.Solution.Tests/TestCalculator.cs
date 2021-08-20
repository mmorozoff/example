using System.Collections.Generic;
using NUnit.Framework;
using No3.Solution.Var2;

namespace No3.Solution.Tests
{
    [TestFixture]
    public class TestCalculator
    {
        private readonly List<double> values = new List<double> { 10, 5, 7, 15, 13, 12, 8, 7, 4, 2, 9 };

        [Test]
        public void Test_AverageByMean()
        {
            Calculator calculator = new Calculator();
            MeanMethod method = new MeanMethod();

            double expected = 8.3636363;

            double actual = calculator.CalculateAverage(values, method);

            Assert.AreEqual(expected, actual, 0.000001);
        }

        [Test]
        public void Test_AverageByMedian()
        {
            Calculator calculator = new Calculator();
            MedianMethod method = new MedianMethod();
            double expected = 8.0;

            double actual = calculator.CalculateAverage(values, method);

            Assert.AreEqual(expected, actual, 0.000001);
        }

        [Test]
        public void Test2_AverageByMean()
        {
            Calculator2 calculator = new Calculator2();
            MeanMethod method = new MeanMethod();

            double expected = 8.3636363;

            double actual = calculator.CalculateAverage(values, method.Calculate);

            Assert.AreEqual(expected, actual, 0.000001);
        }

        [Test]
        public void Test2_AverageByMedian()
        {
            Calculator2 calculator = new Calculator2();
            MedianMethod method = new MedianMethod();
            double expected = 8.0;

            double actual = calculator.CalculateAverage(values, method.Calculate);

            Assert.AreEqual(expected, actual, 0.000001);
        }
    }
}
