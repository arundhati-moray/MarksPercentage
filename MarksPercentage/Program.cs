using ClassLibrary1;

class MarksPercentage
{
    static void Main()
    {
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
        Console.WriteLine($"Percentage of Student1 is : {student1.Percentage}");

        student2.CalculatePercentage();
        Console.WriteLine($"Percentage of Student2 is : {student2.Percentage}");



    }
}