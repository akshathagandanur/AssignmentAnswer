using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssessmentQuestions
{
    class RealNum
    {
        static void Main(string[] args)
        {
            int negativecount = 0;
            int positivesum = 0;
            int negativesum = 0;
            int positivecount = 0;
            for(int i=1;i<=10;i++)
            {
                Console.WriteLine("enter 10 numbers");
               int n = Convert.ToInt32(Console.ReadLine());
                if (n>0)
                {
                    positivesum =positivesum+n;
                    positivecount = positivecount+1;
                   
                }
                else
                {
                    negativesum = negativesum+ n;
                    negativecount = negativecount+1;
                   
                }

            }
            Console.WriteLine($"The avg of positive number is:{positivesum/positivecount} The avg of negative number is{negativesum/negativecount}");


        }
    }
}
