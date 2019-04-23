using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpSection2.Classes;

namespace CSharpSection2
{
    class Program
    {
        static IOperations am;
        static void Main(string[] args)
        {
            //Console.WriteLine(SimpleMath.Add(123.11f, 134.34f));
            //Console.WriteLine(SimpleMath.Subtract(123.11f, 134.34f));
            //Console.WriteLine(SimpleMath.Multiply(123.11f, 134.34f));
            //Console.WriteLine(SimpleMath.Divide(123.11f, 134.34f));
            /*
            am = new AdvancedMath();
            Console.WriteLine(am.Remainder(7, 3));*/

            /*
            BankAccount bankAccount1 = new BankAccount(13235.23f, "Jane Doe");
            ChildBankAccount bankAccount2 = new ChildBankAccount(2354.12f, "John Doe", "Jane Doe");

            Console.WriteLine(bankAccount1.Owner +"'s balance is: " + bankAccount1.AddBalance(100f));
            Console.WriteLine(bankAccount2.Owner +"'s balance is: " + bankAccount2.AddBalance(-3100f,true));
            */
            GetData();
            Console.ReadLine();
        }

        //make it async
        async static void GetData()
        {
            BankAccount bankAccount = new BankAccount(245456546, "Uncle Sam");

            Console.WriteLine("Log in");
         //   await bankAccount.GetData();
            var task = await bankAccount.GetData();
            Console.WriteLine("Display data");
            Console.WriteLine(task);
        }
    }

    interface IOperations
    {
        float Remainder(float dividend, float divisor);

    }

    class SimpleMath
    {
        public static float Add(float n1, float n2)
        {
            return n1 + n2;
        }

        public static float Subtract(float n1, float n2)
        {
            return n1 - n2;
        }

        public static float Multiply(float n1, float n2)
        {
            return n1 * n2;
        }

        public static float Divide(float n1, float n2)
        {
            return n1 / n2;
        }
    }

    class AdvancedMath : SimpleMath, IOperations
    {
        public float Remainder(float dividend, float divisor)
        {
            return dividend % divisor;
        }
    }
}
