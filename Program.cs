using System;
using System.IO;
using static System.Math;

namespace variables
{
    class Program
    {
        static void Main(string[] args)
        {
           //31-Jan-2019
           //Variables are the containers for storing our data or information
           //Datatypes define the set of allowed inputs to given variable
           //Conventions for naming a variable are that 
           //1. The variable name should always start with a lowercase ,a letter ,digit or underscore
           //2.The variable should not be a key word
           //Declaration 
           string name;
           char letter;
           bool iswild;
           int number;
           decimal salary;
           float height;
           double weight;
           long biginterger;
           DateTime date;


            //Initializing declared variables by values from console-
            height = 1.855f;

            Console.WriteLine("Write your name here");
            name = Console.ReadLine();
           Console.WriteLine("Write the second character of your second name");
           letter = Convert.ToChar(Console.ReadLine());
           Console.WriteLine("The lion is a wild animal , type true to agree and false to object");
           iswild = Convert.ToBoolean(Console.ReadLine());
           Console.WriteLine("Enter any luck number btn 1 and 9");
           number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the amount of salary you earn per month");
           salary = Convert.ToDecimal(Console.ReadLine());
          Console.WriteLine("State the value of your weight");
           weight = Convert.ToDouble(Console.ReadLine());
          Console.WriteLine("Phone number");
           biginterger = Convert.ToInt64(Console.ReadLine());
           Console.WriteLine("Write your date of birth");
           date = Convert.ToDateTime(Console.ReadLine());
           Console.Clear();
           Console.WriteLine("My name is "+name);
           Console.WriteLine("The second character of my second name is "+letter);
           Console.WriteLine("The lion is a wild animal "+iswild);
           Console.WriteLine("The salary I earn per month is "+salary);
           Console.WriteLine("My weight is "+weight);
           Console.WriteLine("My phone number is "+biginterger);
           Console.WriteLine("My date of birth is "+date);
           Console.ReadKey();

        }
    }
}
