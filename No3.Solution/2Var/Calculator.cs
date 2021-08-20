using System;
using System.Collections.Generic;
using System.Text;

namespace No3.Solution.Var2
{
    public class Calculator2
    {
        public double CalculateAverage(List<double> values, Func<List<double>, double> averagingMethod)
        {
            if (values == null)
            {
                throw new ArgumentNullException(nameof(values));
            }

            return averagingMethod(values);
        }
    }
}
