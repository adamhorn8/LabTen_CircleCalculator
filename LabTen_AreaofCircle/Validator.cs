using System;
namespace LabTen_AreaofCircle
{
    public class Validator
    {
        public static double ValidateRadius()
        {
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Please enter a Radius");
                string RadiusS = Console.ReadLine();

                double Radius = 0;

                bool RadiusB = double.TryParse(RadiusS, out Radius);

                if (RadiusB == true)
                {
                    return Radius;
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("That was not a number");
                }
            }
        }
    }
}
