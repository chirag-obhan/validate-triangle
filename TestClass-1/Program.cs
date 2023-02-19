using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestClass_1
{
    public class Triangle
    {
        //Chirag Obhan - 8890504
        static void Main(string[] args)
        {

        }

        public static string ValidTriangle(int firstAngle, int secondAngle, int
thirdAngle)
        {
            string result;
            if ((firstAngle + secondAngle + thirdAngle) == 90)
            {
                result = "The triangle is valid.";
            }
            else
            {
                result = "The triangle is NOT valid.";
            }
            return result;
        }
    }
}
