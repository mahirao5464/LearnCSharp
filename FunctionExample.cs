using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCSharp
{
     public class FunctionExample
    {
       public  int rollNumber;
       public  string name;
        public static string schoolName ="xyz school";
        public static void MyMethod(FunctionExample obj)
        {
            Console.WriteLine("Hi, This is mymethod portion");
            obj.Method2();
        }
        public void Method2()
        {
            
            Console.WriteLine("this is method 2");
        }
    }
}
