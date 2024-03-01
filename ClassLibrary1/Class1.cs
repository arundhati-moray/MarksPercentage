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

        public void SetMaths(int Maths)
        {
            this.Maths = Maths;
        }

        public void SetScience(int Science)
        {
            this.Science = Science;
        }

        public void SetComputerScience(int ComputerScience)
        {
            this.ComputerScience = ComputerScience;
        }

        public double GetMaths()
        {
            return Maths;
        }
        public double GetScience()
        {
            return Science;
        }
        public double GetComputerScience()
        {
            return ComputerScience;
        }

        public double GetPercentage()
        {
            return Percentage;
        }
        public void CalculatePercentage()
        {
            double P = (((Maths + ComputerScience + Science) * 100) / 300);
            Percentage = P;
        }

        public static double GetTotalMarks(StudentMarks student1, StudentMarks student2)
        {
            double totalMarks;
            totalMarks = student1.GetMaths() + student2.GetMaths() + student1.GetComputerScience() + student2.GetComputerScience() + student1.GetScience() + student2.GetScience();
            return totalMarks;
        }



    }
}
