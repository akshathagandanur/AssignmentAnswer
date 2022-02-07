using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssessmentQuestions
{
    class Primeno
    {

        //static Boolean IsPrime(int num)

        //{
        //    //Console.WriteLine("Enter the number");
        //    //int a = Convert.ToInt32(Console.ReadLine());
        //    for (int a=1;a<num;a++)
        //    {
        //        if (num % a == 0 && a != num)
        //            return false;
        //    }
        //    return true;
        //}

        //static void Main(string[] args)
        //{
        //    //Console.WriteLine("Enter the number");
        //   // int a = Convert.ToInt32(Console.ReadLine());
        //    bool res=IsPrime(9);
        //    Console.WriteLine(res);


        static void Prime(int num)
        {
            bool prime = true;
            for (int a = 2; a < num; a++)
            {
                if (num % a == 0)
                    prime= false;
            }
            if (prime == true)
            {
                Console.WriteLine(num + " is a prime number");
            }
            else
            {
                Console.WriteLine(num + "is not a prime number");
            }
        }

        static void Main(string[] args)
        {
            //Console.WriteLine("Enter the number");
            // int a = Convert.ToInt32(Console.ReadLine());

            Prime(3);

        }
    }
}
