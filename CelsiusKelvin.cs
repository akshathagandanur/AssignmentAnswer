using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssessmentQuestions
{
    class Celsius
    {
        static void Main()
        {
            Console.Write("Enter the celsius degree:");
            int celsius = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Kelvin={0} ", celsius + 273);
            Console.WriteLine("fahrenheit={0} ", celsius * 18 / 10 + 32);
        }
    }
}
