using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace No3.Solution.Var2
{
    public class MeanMethod
    {
        public double Calculate(List<double> values)
        {
            return values.Sum() / values.Count;
        }
    }
}
