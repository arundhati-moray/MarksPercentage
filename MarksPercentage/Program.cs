using ClassLibrary1;

class MarksPercentage
{
    static void Main()
    {
        double TotalMarks;
        StudentMarks student1 = new StudentMarks
        {
            Maths = 96,
            Science = 100,
            ComputerScience = 88
        };
        StudentMarks student2 = new StudentMarks
        {
            Maths = 96,
            Science = 80,
            ComputerScience = 88
        };


        student1.CalculatePercentage();
        Console.WriteLine($"Percentage of Student1 is : {student1.Percentage}");

        student2.CalculatePercentage();
        Console.WriteLine($"Percentage of Student2 is : {student2.Percentage}");
       


        // Total marks of student1 and student2
        TotalMarks =  StudentMarks.GetTotalMarks(student1 , student2);
        Console.WriteLine($"Total Marks of all the Students is: {TotalMarks}");

        // displaying the additional subjects of student1 & student 2 using params parameter modifier
        student1.DisplayAdditionalSubjects("Biology","Civics","Geography","Physics","Chemistry");
        student2.DisplayAdditionalSubjects("Biology","Civics","Geography","Physics","Chemistry");


    }
}