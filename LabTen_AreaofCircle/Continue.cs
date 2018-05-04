using System;
namespace LabTen_AreaofCircle
{
    public class Continue
    {
        public static string ContinueProg()
        {
            while (true)
            {
                Console.WriteLine("Would you like to continue (y/n)");
                string Continue = Console.ReadLine().ToUpper();

                if (Continue == "Y")
                {
                    continue;
                }
                else if (Continue == "N")
                {

                }
                else
                {
                    Console.WriteLine("Sorry I didn't get that please try again?");
                }
            }
        }
    }
}
