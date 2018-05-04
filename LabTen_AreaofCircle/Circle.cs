using System;
namespace LabTen_AreaofCircle
{
    public class Circle
    {
        public double CalculateCircumference()
        {
            return(2 * Radius * System.Math.PI);
        }

        public string CalculateFormattedCircumference()
        {
            return FormatNumber(Circumference);
        }

        public double CalculateArea()
        {
            return(System.Math.PI * (Radius*Radius));
        }

        public string CalculateFormattedArea()
        {
            return FormatNumber(Area);
        }

        private string FormatNumber(double x)
        {
            return x.ToString("#.00");
        }

        public string AreaForm;
        public string CircumferenceForm;
        public double Circumference;
        public double Area;
        private double Radius { get; set; }
        public double radius { get => Radius; }
        public Circle(double radius)
        {
            Radius = radius;
            Circumference = CalculateCircumference();
            CircumferenceForm = CalculateFormattedCircumference();
            Area = CalculateArea();
            AreaForm = CalculateFormattedArea();
        }
    }
}
