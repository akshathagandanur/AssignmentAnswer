using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssessmentQuestions
{
    class Sumofevandandodds
    {
        static void Main()
        {
            sumofevenandodds();
        }
        static void sumofevenandodds()
        {
            int evenresult = 0;
            int oddresult = 0;
            int[] arr = new int[10];
            for (int k = 0; k < arr.Length; k++)
            {
                Console.WriteLine($"Enter the number{k + 1}");
                arr[k] = int.Parse(Console.ReadLine());
            }
            foreach (int l in arr)
            {
                if (l % 2 == 0)
                {
                    evenresult = l+ evenresult;
                }
                else
                {
                    oddresult = l + oddresult;
                }
            }
            Console.WriteLine($"Even result is {evenresult} and odd result is {oddresult}");
        }
    }
}