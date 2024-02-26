using ClassLibrary1;

class MarksPercentage
{
    static void Main()
    {
        StudentMarks student1 = new StudentMarks();
        StudentMarks student2 = new StudentMarks();

        //initialization
        student1.Maths = 95;
        student1.Science = 98;
        student1.ComputerScience = 100;

        student2.Maths = 96;
        student2.Science = 99;
        student2.ComputerScience = 100;

        student1.CalculatePercentage();
        Console.WriteLine($"Percentage of Student1 is : {student1.Percentage}");

        student1.CalculatePercentage();
        Console.WriteLine($"Percentage of Student2 is : {student2.Percentage}");


    }
}