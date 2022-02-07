using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssessmentQuestions
{
    class Loopingintegers
    {
        static void Main()
        {
            LoopI();
        }
        static void LoopI()
        {
            bool verify = true;
            List<string> var = new List<string>();

            do
            {
                Console.WriteLine("Enter the value:");
                var.Add(Console.ReadLine());
                Console.WriteLine("If u want to continue press Yes or No");
                string reply = Console.ReadLine();
                verify = reply == "No";
            } while (verify);

            Console.WriteLine("The total count is :" + var.Count);
            List<int> integer = new List<int>();
            List<string> noninteger = new List<string>();
            foreach (var element in var)
            {
                int no = 0;
                if (int.TryParse(element, out no))
                {
                    integer.Add(no);
                }
                else
                {
                    noninteger.Add(element);
                }

            }

            Console.WriteLine("The no of integer values is count is " + integer.Count);
            Console.WriteLine("The no of noninteger values count is " + noninteger.Count);
            Console.WriteLine("The sum of the all integer values is " + integer.Sum());

            Console.WriteLine("printing all integers:");
            foreach (int i in integer)
            {
                Console.WriteLine(i + "  ");
            }

            Console.Write("The non integer values is :");
            foreach (string s in noninteger)
            {
                Console.Write(s + "  ");
            }

            Console.WriteLine("The total values is:");
            foreach (var i in var)
            {
                Console.Write(i + "  ");
            }
        }
    }
}