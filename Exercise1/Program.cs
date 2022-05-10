using System;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            string str; //To save the entered string
            bool EnterButton = false; // For checking th button "Enter" if it is pressed 
            do
            {
                Console.WriteLine("Press any button to enter an emplyee's information or press 'Enter' to exit.");
                str = Console.ReadLine(); //Allow the user to enter a string
                EnterButton = String.Equals(str, ""); // Compare it with "Enter" button and store the logic  
                Console.WriteLine();
                if (EnterButton != true)  //Check out the logic if "Enter" button wasn't pressed then proceed  
                {
                    Personnel personalregister = new Personnel(); //Create 
                    personalregister.Start(); //Call a method of the object to run
                }
                else
                {   //Print out this sentence if the "Enter" button was pressed
                    Console.WriteLine("OK. You pressed Enter. See you again!");
                }
            }
            while (EnterButton != true);  //Keep repeating as long as the enter button has not pressed           
        }
    }
}
