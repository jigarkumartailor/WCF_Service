using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace TestWCFService
{
    [ServiceContract]
    interface IMyService
    {
        [OperationContract]
        string GetString();

        [OperationContract]
        string GetMessage(string name);

        [OperationContract]
        string GetResult(int SId, string Name, int m1, int m2, int m3);
        [OperationContract]
        int MaxArraynumber(int[] arr);

        [OperationContract]
        int[] sortedArray(int[] arr);

    }
}
