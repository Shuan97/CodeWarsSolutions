using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsSolutions._8_kyu
{
    static class CalculateBMI
    {
        public static string Bmi(double weight, double height)
        {
            var bmi = weight / (height * height);
            return bmi <= 18.5 ? "Underweight" : bmi <= 25.0 ? "Normal" : bmi <= 30.0 ? "Overweight" : "Obese";
        }
    }
}
