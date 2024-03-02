using ClassLibrary1;

class MarksPercentage
{
    static void Main()
    {
        double TotalMarks;
        StudentMarks student1 = new StudentMarks();
        StudentMarks student2 = new StudentMarks();

        //initialization
        student1.SetMaths(95);
        student1.SetScience(98);
        student1.SetComputerScience(100);

        student2.SetMaths(96);
        student2.SetScience(99);
        student2.SetComputerScience(100);

        student1.CalculatePercentage();
        Console.WriteLine($"Percentage of Student1 is : {student1.GetPercentage()}");

        student2.CalculatePercentage();
        Console.WriteLine($"Percentage of Student2 is : {student2.GetPercentage()}");

        // Total marks of student1 and student2
        TotalMarks =  StudentMarks.GetTotalMarks(student1 , student2);
        Console.WriteLine($"Total Marks of all the Students is: {TotalMarks}");

        // displaying the additional subjects of student1 & student 2 using params parameter modifier
        student1.DisplayAdditionalSubjects("Biology","Civics","Geography","Physics","Chemistry");
        student2.DisplayAdditionalSubjects("Biology","Civics","Geography","Physics","Chemistry");


    }
}