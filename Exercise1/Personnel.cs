using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Personnel
    {
        private string name;     //Name 
        private double wage;     //Wage

        public Personnel()
        {
            name = "";
            wage = 0.0;
        }

        public void ReadName()
        {
            //Read a line of text
            Console.Write("What is the name of the emplyee? ");
            name = Console.ReadLine();
        }

        public void ReadWage()
        {
            //Read a whole number
            Console.Write("What is " + name + "'s wage? ");
            string textValue = Console.ReadLine();
            //convert string to number
            wage = double.Parse(textValue.Trim());
        }

        public void ReadAndSaveTheData()
        {
            ReadName(); // Read the name value 
            ReadWage(); // Read the wage value   
        }

        public void DisplayEmployeeInfo()   //Display all the values 
        {
            Console.WriteLine("-----------------The employee---------------------");
            string textOut = "Name: " + name + " Wage: " + wage;
            Console.WriteLine(textOut);
            Console.WriteLine();

        }

        public void Start()
        {
            ReadAndSaveTheData();
            DisplayEmployeeInfo();
        }
    }
}
