using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
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
        string GetResult(Student s);
        [OperationContract]
        int MaxArraynumber(int[] arr);

        [OperationContract]
        int[] sortedArray(int[] arr);

        [OperationContract]
        Student GetTopper(List<Student> LS);

    }

    [DataContract]
    class Student
    {
        [DataMember]
        public int sId { get; set; }
        [DataMember]
        public string Sname { get; set; }
        [DataMember]
        public int M1 { get; set; }
        [DataMember]
        public int M2 { get; set; }
        [DataMember]
        public int M3 { get; set; }
    }
}
