using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Debug.Print("Primitive");
            int A;
            int B;

            A = 1;
            B = 2;

            B = A;
            Debug.Print($"  A={A}, B={B}");

            B = 3;
            Debug.Print($"  A={A}, B={B}");

            Debug.Print("String");
            string sA;
            string sB;

            sA = "abc";
            sB = "def";

            sB = sA;
            Debug.Print($"  sA={sA}, sB={sB}");

            sB = "123";
            Debug.Print($"  sA={sA}, sB={sB}");

            Debug.Print("Object");
            AA classA = new AA();
            AA classB = new AA();
            AA classC = new AA();
            classA.Value = 1;
            classB.Value = 2;
            classC.Value = 3;

            classB = classA;
            Debug.Print($"  A={classA.Value}, B={classB.Value}, C={classC.Value}");

            classB.Value = 4;
            Debug.Print($"  A={classA.Value}, B={classB.Value}, C={classC.Value}");

            classB.Value = classC.Value;
            Debug.Print($"  A={classA.Value}, B={classB.Value}, C={classC.Value}");

            Debug.Print("Method Args");
            HogeByVal(classA);
            Debug.Print($"  Byval  A={classA.Value}");

            HogeByRef(ref classA);
            Debug.Print($"  Byval  A={classA.Value}");
        }


        static void HogeByVal(AA val1)
        {
            AA val = new AA();
            val.Value = 10;
            val1 = val;
        }

        static void HogeByRef(ref AA val1)
        {
            AA val = new AA();
            val.Value = 10;
            val1 = val;
        }
    }


    class AA
    {
        public int Value { get; set; }

    }
}
