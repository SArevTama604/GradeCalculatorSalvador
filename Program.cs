namespace GradeCalculatorSalvador
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the student's score:");
            int score = Convert.ToInt32(Console.ReadLine());

            char grade;
            if (score >= 90)
            {
                grade = 'A';
            }
            else if (score >= 80)
            {
                grade = 'C';
            }
            else if (score >= 60)
            {
                grade = 'D';
            }
            else
            {
                grade = 'F';
            }
            Console.WriteLine("The student's letter grade is: " + grade);
        }
    }
}
