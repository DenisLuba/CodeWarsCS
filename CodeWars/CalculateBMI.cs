using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    public class CalculateBMI
    {
        public static string Bmi(double weight, double height)
        {
            var bmi = weight / (height * height);
            return bmi <= 18.5 ? "Underweight"
                : bmi <= 25 ? "Normal"
                : bmi <= 30 ? "Overweight"
                : "Obese";
        }
    }
}
