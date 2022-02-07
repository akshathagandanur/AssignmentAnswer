using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssessmentQuestions
{
    class PersonProg
    {
    public class Student
    {

        public Student(string name, string city, string state, string school, int year, double fees)
        {
        }
    }
    public class Staff
    {

        public Staff(string name, string city, string state, string school, double salary)
        {
        }
    }
    public class Person
    {


        public Person(string v1, string v2, string v3, string v4, double v5)
        {
            Console.WriteLine("Staff Details:" + "Name: " + v1 + ", City:" + v2 + ", State: " + v3 + ", School: " + v4 + ", Salary: " + v5);

        }
        public Person(string name, string city, string state, string school, int year, double fees)
        {
            Console.WriteLine("Student Details:" + "Name: " + name + ", City: " + city + ", State: " + state + ", Year: " + year + ", fees:" + fees);
        }


        static void Main(string[] args)
        {

            Person[] pple = {
                                new Person("Akshatha", "Bangalore", "Karnataka", " Chinmayi vidyalayam", 2018, 4500.0),
                                new Person("Apoorva", "Bangalore"," Karnataka", "VidyaSiri school", 35000.0),
                                new Person("Siri", "Baroda", "Gujarat", "National Public school", 2000.0),
                                new Person("Akshay", "Chitradurga", "Karnataka", " Bapuji Institute", 2021, 9750.0),
                                new Person("Chayu", "Dvg", "Goa", "Reactjs", 2012, 19469.0)
                                };
            Console.ReadLine();
        }
    }
 }
}
