using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssessmentQuestions
{
    class SortThreeNumbers
    {
        public void sortThree(int a,int b,int c)
        {
            //Console.WriteLine("Enter the no a:");
            //a = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter the no b:");
            //b = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter the no c");
            //c = Convert.ToInt32(Console.ReadLine());

            if(a<b && a<c)
            {
                if(b<c)
                {
                    Console.WriteLine($"ascending order:{a},{ b},{ c}");
                }
                else
                {
                    Console.WriteLine($"Ascending order :{a},{c},{b}");
                }
            }
            else if(b<a && b<c)
            {
                if(a<c)
                {
                    Console.WriteLine($"ascending order:{b},{a},{c}");

                }
                else
                {
                    Console.WriteLine($"ascending order:{b},{c},{a}");
                }
            }
            else if(c<a && c<b)
            {
                if (a < b)
                {
                    Console.WriteLine($"ascending order:{c},{a},{b}");
                }
                else
                {
                    Console.WriteLine($"Ascending order:{c},{b},{a}");
                }
                

            }
            else
            {
                Console.WriteLine("Print invalid");
            }
        }
        static void Main(string[] args)
        {
            SortThreeNumbers stn = new SortThreeNumbers();
            //stn.sortThree();
           stn.sortThree(20, 10, 2);
            stn.sortThree(82, 90, 45);
            stn.sortThree(1008, 390, 6783);
        }
    }
}
