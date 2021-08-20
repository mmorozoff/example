using System;
using System.Collections.Generic;
using System.Text;

namespace No3.Solution
{
    public class Calculator
    {
        public double CalculateAverage(List<double> values, ICalculate averagingMethod)
        {
            if (values == null)
            {
                throw new ArgumentNullException(nameof(values));
            }

            return averagingMethod.Calculate(values);
        }
    }
}
