using System;

namespace LabTen_AreaofCircle
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare variables for later user
            int count = 0;
            bool KeepGoing = true;

            //Introduce the program to user
            Console.WriteLine("Welcome to the Circcle Tester");

            //Create while loop to allow user to calculate numerous circles
            while (KeepGoing)
            {
                //Call Validator class to ask user for input and validate that input
                Circle CircleOne = new Circle(Validator.ValidateRadius());

                //Display the information about the circles
                Console.WriteLine($"Circumference: {CircleOne.CircumferenceForm}");
                Console.WriteLine($"Area: {CircleOne.AreaForm}");

                //Counter adds one each time the while loop iterates
                count++;

                KeepGoing = ContinueProg();
            }
            Console.WriteLine();
            Console.WriteLine($"Thanks, you calculated {count} circles");
        }
        //New method to ask if user would like to continue and enter another radius
        public static bool ContinueProg()
        {
            bool LikeCont = true;

            //While loop to validate input
            while (LikeCont)
            {
                Console.WriteLine();
                Console.WriteLine("Would you like to continue (y/n)");
                string Continue = Console.ReadLine().ToUpper();

                if (Continue == "Y")
                {
                    LikeCont = false;
                    return true;
                }
                else if (Continue == "N")
                {
                    LikeCont = false;
                    return false;
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Sorry I didn't get that please try again?");
                    LikeCont = true;
                }
            }
            return false;
        }
    }
}
