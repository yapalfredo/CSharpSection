using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSection
{
    class Program
    {
        static int n1 = 432, n2 = 543;
        private static void Main(string[] args)
        {
            Console.WriteLine(Add());
            Console.WriteLine(Subtract());
            Console.WriteLine(Divide());
            Console.WriteLine(Multiply());

            Console.ReadLine();
        }

        private static int Add()
        {
            int result;
            result = n1 + n2;

            return result;
        }

        private static int Subtract()
        {
            int result;
            if (n1 > n2)
            {
                result = n1 - n2;
            }
            else
            {
                result = n2 - n1;
            }            
            return result;
        }

        private static int Divide()
        {
            int result;
            if (n1 > n2)
            {
                result = n1 / n2;
            }
            else
            {
                result = n2 / n1;
            }
            return result;
        }

        private static int Multiply()
        {
            int result;
            result = n1 * n2;
            return result;
        }


    }
}
