using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class StudentMarks
    {
      //  private double Maths;
       // private double Science;
       // private double ComputerScience;
        //private double Percentage;

        /*   public void SetMaths(int Maths)
           {
               this.Maths = Maths;
           } */

        public int Maths { get; set; }
        public int Science { get; set; }
        public int ComputerScience { get; set; }
        public double Percentage {  get; set; }

    /*    public double GetMaths()
        {
            return Maths;
        } */
       
        public void CalculatePercentage()
        {
            double P = (((Maths + ComputerScience + Science) * 100) / 300);
            Percentage = P;
        }

        public static double GetTotalMarks(StudentMarks student1, StudentMarks student2)
        {
            double totalMarks;
            totalMarks = student1.Maths + student2.Maths + student1.ComputerScience + student2.ComputerScience + student1.Science + student2.Science;
            return totalMarks;
        }

        //DisplayAllSubjects Method that uses params Parameter modifier
        public void DisplayAdditionalSubjects(params string[] Subjects)
        {
            for(int i = 0 ; i < Subjects.Length ; i++)
            {
                Console.WriteLine($"The subject is: {Subjects[i]}");
            }
        }


    }
}
