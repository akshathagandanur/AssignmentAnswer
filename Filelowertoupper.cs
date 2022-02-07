using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AssessmentQuestions
{
    class FileLowerCaseToUpperCase
    {
        static void Main()
        {

            string fadd = @"C:\Users\Akshatha G\source\repos\AssessmentQuestions\AssessmentQuestions\EmpData.csv";

            if (File.Exists(fadd))
            {
                StreamReader freader = File.OpenText(fadd);
                StreamWriter fWrite = File.CreateText(fadd + "uppercase" + ".csv");
                string line;
                do
                {
                    line = freader.ReadLine();
                    if (line != null)
                    {
                        fWrite.WriteLine(line.ToUpper());
                        Console.WriteLine(line.ToUpper());
                    }
                }
                while (line != null);
                freader.Close();
                fWrite.Close();
                if (File.Exists(fadd + "uppercase" + ".csv"))
                    Console.WriteLine("Conversion successful!");
                Console.ReadLine();
            }
        }
    }
}