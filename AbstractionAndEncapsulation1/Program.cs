 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionAndEncapsulation1
{
      
    class Program:MyClass
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();
     
            Program program = new Program();
            program.number1 = 2;

            Console.Read();

        }
    }
    class MyClass
    {
        protected int number1; // Gets Inherited by the child Class
        public string MyString()
        {
           int number;

            return " ";
        }
    }
}
