using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssessmentQuestions
{
    class Pattern
    {
        static void Main(string[] args)
        {
            int u, v;
            for (u = 1; u <= 5; u++)
            {
                for (v = 1; v <= u; v++)
                {
                    Console.Write("$");
                }
                Console.WriteLine();

            }
            Console.ReadLine();
        }
    }
}
