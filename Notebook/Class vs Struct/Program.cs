using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_vs_Struct
{
    class Program
    {
        static void Main(string[] args)
        {
            MyStruct myStruct = new MyStruct();
            myStruct.change = "didn't change";
            
            MyClass myClass = new MyClass();
            myClass.change = "didn't change";

            ClassTaker(myClass);
            StructTaker(myStruct);

            Console.WriteLine("Struct: "+ myStruct.change);
            Console.WriteLine("Class: " + myClass.change);

            Console.ReadLine();
        }
        static void ClassTaker(MyClass myClass)
        {
            myClass.change = "changed";
        }
        static void StructTaker(MyStruct myStruct)
        {
            myStruct.change = "changed";
        }
    }
    class MyClass
    {
        public string change;
    }
    struct MyStruct
    {
        public string change;
    }
}
