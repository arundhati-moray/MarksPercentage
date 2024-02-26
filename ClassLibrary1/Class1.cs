using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class StudentMarks
    {
        public double Maths;
        public double Science;
        public double ComputerScience;
        public double Percentage;


        public void CalculatePercentage()
        {
            double P = (((Maths + ComputerScience + Science) * 100) / 300);
            Percentage = P;
        }



    }
}
