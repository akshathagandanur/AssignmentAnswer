using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssessmentQuestions
{
    class Trignometry
    {
        static int fac(int g)
        {
            int i, fac = 1;
            for (i = 1; i <= g; i++)
                fac = fac * i;
            return fac;
        }
        static float pow(float nu, int exp)
        {
            float result = 1;
            while (exp != 0)
            {
                result *= nu;
                --exp;
            }
            return result;
        }
        static void Main(string[] args)
        {
            float a, P, sum = 0;
            int m, n, limit;

            Console.WriteLine("Enter value of a : ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the limit upto which u want to expand : ");
            limit = Convert.ToInt32(Console.ReadLine());
            P= a;
            a = (float)(a * (3.1415 / 180));

            for (m = 1, n= 1; m <= limit; m++, n = n+ 2)
            {
                if (m % 2 != 0)
                {
                    sum = sum + pow(a, n) / fac(n);
                }
                else
                    sum = sum - pow(a, n) / fac(n);
            }

            Console.WriteLine("Sign of x value is : " + P + ", " + sum);
            Console.ReadLine();
        }
    }
}