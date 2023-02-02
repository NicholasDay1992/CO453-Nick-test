using System;

namespace ConsoleAppProject.App01
{
    /// <summary>
    /// Please describe the main features of this App
    /// </summary>
    /// <author>
    /// Derek version 0.1
    /// </author>
    public class DistanceConverter
    {
        public void Run()
        {
            ConvertFeetToMiles();
            ConvertMilesToFeet();
        }

        public void ConvertMilesToFeet()
        {
            //step 1 - input the miles
            Console.WriteLine("Enter the number of miles: ");
            string input = Console.ReadLine();
            int miles = Convert.ToInt32(input);

            //step 2 - convert miles to feet

            int feet = miles * 5280;

            // step 3 - output to screen 

            Console.WriteLine(miles + " miles is " + feet + " feet.");
        }

        public void ConvertFeetToMiles()
        {
            //step 1 - input the feet
            Console.WriteLine("Enter the number of feet: ");
            string input = Console.ReadLine();
            double feet = Convert.ToDouble(input);

            //step 2 - convert feet to miles

            double miles = feet / 5280;

            // step 3 - output to screen 

            Console.WriteLine(feet + " feet is " + miles.ToString("0.00") + " miles.");

        }
    }
}
