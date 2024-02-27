using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class StudentMarks
    {
        private double Maths;
        private double Science;
        private double ComputerScience;
        private double Percentage;

        public void SetMaths(int value)
        {
            Maths = value;
        }

        public void SetScience(int value)
        {
            Science = value;
        }

        public void SetComputerScience(int value)
        {
            ComputerScience = value;
        }

        public int GetMaths()
        {
            return Maths;
        }
        public int GetScience()
        {
            return Science;
        }
        public int GetComputerScience()
        {
            return ComputerScience;
        }

        public void CalculatePercentage()
        {
            double P = (((Maths + ComputerScience + Science) * 100) / 300);
            Percentage = P;
        }



    }
}
