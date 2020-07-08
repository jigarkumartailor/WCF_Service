using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWCFService
{
    class MyService : IMyService
    {
        public string GetMessage(string name)
        {
            return "Mr." + name;
        }

        public string GetResult(int SId, string Name, int m1, int m2, int m3)
        {
            double Avg = (m1 + m2 + m3) / 3;
            if (Avg > 35)
            {
                return "Pass";
            }
            else
            {
                return "Fail";
            }
             
        }

        public string GetString()
        {
            return "Jigar Tailor";
        }

        public int MaxArraynumber(int[] arr)
        {
            int Max = arr[0];
            for (int i = 0; i < arr.Length-1; i++)
            {
                if (Max < arr[i])
                {
                    Max = arr[i];
                }
            }
            return Max;
        }

        public int[] sortedArray(int[] arr)
        {
            Array.Sort(arr);
            return arr;

        }
    }
}
