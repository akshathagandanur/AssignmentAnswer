using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssessmentQuestions
{
    class Encryption
    {
        static void Main()
        {
            string newText = EncryptDecrypt.encrypt("Akshatha");
            Console.WriteLine("Text Encripted: {0}", newText);
            string TextDescripted = EncryptDecrypt.decrypt(newText);
            Console.WriteLine("Text Decripted: {0}", TextDescripted);
            Console.ReadLine();
        }
    }
    class EncryptDecrypt
    {
        public static string encrypt(string txt)
        {
            char letter = ' ';
            int letterInt = 0;
            string textEncripted = "";
            for (int i = 0; i < txt.Length; i++)
            {
                letterInt = (int)txt[i] + 1;
                letter = (char)letterInt;
                textEncripted += letter.ToString();
            }
            return textEncripted;
        }

        public static string decrypt(string txt)
        {
            int letterInt = 0;
            char letter = ' ';
            string textDecripted = "";
            for (int i = 0; i < txt.Length; i++)
            {
                letterInt = (int)txt[i] - 1;
                letter = (char)letterInt;
                textDecripted += letter.ToString();
            }
            return textDecripted;
        }
    }
    
}