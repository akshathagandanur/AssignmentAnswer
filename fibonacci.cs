using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssessmentQuestions
{
    class Fibonacci
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number : ");
            int index = Convert.ToInt32(Console.ReadLine());
            FibSeries fib = new FibSeries();
            int num = fib.Fibo(index);
            Console.WriteLine("Number at index position " + index + " is:" + num);
            Console.ReadLine();
        }

    }
    class FibSeries
    {
        public int Fibo(int index)
        {
           
            int first = 0;
            int second = 1;
            int sum = 0;
            Console.WriteLine(first + " " + " ");
            int[] fib = new int[10];
            fib[0] = first;
            Console.WriteLine(fib[0]);
            fib[1] = second;
            for (int i = 2; i <= fib.Length - 1; i++)
            {
                sum = first + second;
                Console.WriteLine(sum + " ");
                fib[i] = sum;
                first = second;
                second = sum;
            }
            return fib[index];
        }
    }
}