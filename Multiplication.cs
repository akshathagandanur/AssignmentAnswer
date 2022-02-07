using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssessmentQuestions

{
    class Multiplication
    {
        static void Main()
        {
            int a = 1;
            Console.WriteLine("Enter the number");
            int n = Convert.ToInt32(Console.ReadLine());

            while (a <= 10)
            {
                Console.WriteLine(n + "*" + a + " = " + (n * a));
                a++;
            }

        }
    }
}