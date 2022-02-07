using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssessmentQuestions
{
    class Arraycsv
    {
        static void Main(string[] args)
        {
            string[,] files = new string[3, 5];
            files[0, 0] = "hy haii";
            files[0, 1] = "hello";
            files[0, 2] = "good ";
            files[0, 3] = "morning";
            files[0, 4] = "bangalore";

            //files[1, 0] = "welcome";
            //files[1, 1] = "to";
            //files[1, 2] = "bangalore";
            //files[1, 3] = "thank";
            //files[1, 4] = "you";

            files[2, 0] = "My";
            files[2, 1] = "name";
            files[2, 2] = "is";
            files[2, 3] = "Akshatha";
            files[2, 4] = "Andanur";


            StreamWriter str = File.CreateText("Op.csv");
            for (int i = 0; i < 3; i++)

            {
                for (int j = 0; j < 5; j++)
                {
                    str.Write(files[i, j] + ";");

                }

                str.Write("\n");

            }

            str.Flush();
            str.Close();
            Console.WriteLine("your file is sucesfully created");
        }
    }
}