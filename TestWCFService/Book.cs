using System.Runtime.Serialization;

namespace TestWCFService
{
    [DataContract]
    public class Book
    {
        [DataMember]
        public int BookId { get; set; }
        [DataMember]
        public string BookName { get; set; }

    }
}