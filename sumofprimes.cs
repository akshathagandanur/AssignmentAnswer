using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssessmentQuestions
{
    class SumOfPrimes
    {
        public int sum(int f, int t)
        {
            int Sum = 0;

            for (int i = f; i <= t; i++)
            {
                int count = 0;
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        count++;
                    }
                }
                if (count == 2||count==1)
                {
                    Sum = Sum + i;
                }                           
            }
            return Sum;
        }

      
    }
    class SOP
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the first number");
            int f = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the last number");
            int t = Convert.ToInt32(Console.ReadLine());
            SumOfPrimes sop = new SumOfPrimes();
           int s= sop.sum(f,t);
            Console.WriteLine("the sum of number is:"+s);
        }
    }
}
