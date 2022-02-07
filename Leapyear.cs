using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssessmentQuestions
{
    class Leapyear
    {
        int L;
        public void read()
        {
            Console.WriteLine("Enter the year:");
            L = Convert.ToInt32(Console.ReadLine());

        }
        public void display()
        {
            if((L % 4 == 0 && L % 400==0)||(L%4==0 && !(L% 100 ==0)))
            {
                Console.WriteLine(L + "it is a leap year");
            }
            else
            {
                Console.WriteLine(L+"it is not a leap year");
            }
        }
        class leapdisplay
        {
            static void Main(string[] args)
            {
                Leapyear lp = new Leapyear();
                lp.read();
                lp.display();
            }
        }
    }
}
