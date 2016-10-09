using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WCFSelfHostServices.CalculatorService
{
    [ServiceContract]
    public interface ICalculatorService
    {
        [OperationContract]
        CalculatorData Add(int a, int b);
    }
}
