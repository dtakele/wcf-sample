using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCFSelfHostServices.CalculatorService
{
    public class CalculatorService : ICalculatorService
    {
        public CalculatorData Add(int a, int b)
        {
            var result = new CalculatorData();
            result.Result = a + b;
            return result;
        }
    }
}
