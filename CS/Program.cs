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
            int A;
            int B;

            A = 1;
            B = 2;

            B = A;
            Debug.Print("Ans  A={0}:B={1}", A, B);

            B = 3;
            Debug.Print("Ans  A={0}:B={1}", A, B);

            string sA;
            string sB;

            sA = "abc";
            sB = "def";

            sB = sA;
            Debug.Print("Ans  sA={0}:sB={1}", sA, sB);

            sB = "123";
            Debug.Print("Ans  sA={0}:sB={1}", sA, sB);

            AA classA = new AA();
            AA classB = new AA();
            AA classC = new AA();
            classA.Value = 1;
            classB.Value = 2;
            classC.Value = 3;

            classB = classA;
            Debug.Print("Ans  A={0}:B={1}:C={1}", classA.Value, classB.Value, classC.Value);

            classB.Value = 3;
            Debug.Print("Ans  A={0}:B={1}:C={1}", classA.Value, classB.Value, classC.Value);

            classB.Value = classC.Value;
            Debug.Print("Ans  A={0}:B={1}:C={1}", classA.Value, classB.Value, classC.Value);

            HogeByVal(classA);
            Debug.Print("Byval  A={0}", classA.Value);

            HogeByRef(ref classA);
            Debug.Print("Byref  A={0}", classA.Value);
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
