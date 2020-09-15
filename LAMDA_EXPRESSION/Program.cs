using System;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

namespace LAMDA_EXPRESSION
{
    class Program
    {
        public delegate int math(int p);//public delegate , it is used as a pointer to method having same parameter as delegate
        public static int num = 4;
        static void Main(string[] args)
        {
            
            math n2;
            math n1 = add;
            math n3 = multiply;
            n2 = n1;
            n2 += n3;
            
            Console.WriteLine(n2(4));
            math nc1 = num => num - 1; //lemda expression => is a lemda operator , in equation left side operator are arguments and right side is return value
            nc1(4);
            Console.WriteLine(nc1(4));
        }
        public static int add(int p)
        {
            num +=p;
            return num;   
        }
        public static int multiply(int p)
        {
            num *= p;
            return num;
        }

    }
}
