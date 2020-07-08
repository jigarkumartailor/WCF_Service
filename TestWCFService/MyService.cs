using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWCFService
{
    class MyService : IMyService
    {
        public List<Book> GetBooks()
        {
            List<Book> books = new List<Book>();

            string conString = "Data Source=DOSTI;Initial Catalog=BookListRazor;Integrated Security=True";
            SqlConnection conn = new SqlConnection(conString);

            SqlCommand cmd = new SqlCommand("Select * from Book",conn);
            conn.Open();

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Book book = new Book();
                book.BookId = Convert.ToInt32(reader[0]);
                book.BookName = reader[1].ToString();
                books.Add(book);
            }
            return books;
        }

        public string GetMessage(string name)
        {
            return "Mr." + name;
        }

        public string GetResult(Student s)
        {
            double Avg = (s.M1 + s.M2 + s.M3) / 3;
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

        public Student GetTopper(List<Student> LS)
        {
            Student topper = new Student();
            int topperId = 0;
            int highestMark = 0;

            foreach (Student stud in LS)
            {
                int total= stud.M1 + stud.M2 + stud.M3;
                if (highestMark < total)
                {
                    highestMark = total;
                    topperId = stud.sId;
                }
                    
            }
            topper = LS.Where(s => s.sId == topperId).SingleOrDefault();
            return topper;
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
