namespace gradeCalculator
    /* Author: Meakalia Gilman
     * Class: IGM201.01 Interac Des & Prob Sol III
     * Due: 10.13.24 */
     
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //get name
            string studentName = "Meakalia";
            int[] grades = new int[] { 100, 92, 87, 200, -20, 52, 82, 75, 67, 88 };
            Console.WriteLine("Welcome " + studentName + " :)");

            //print grades
            Console.WriteLine("Here are your grades: ");

            for (int i = 0; i < grades.Length; i++)
            {
                if (grades[i] >= 90 && grades[i] < 100)
                {
                    Console.WriteLine("This grade is an A!");
                    Console.Write(grades[i] + "\n");
                }
                else if (grades[i] == 100)
                {
                    Console.WriteLine("WOW! A perfect score!");
                    Console.Write(grades[i] + "\n");
                }
                else if (grades[i] >= 80 && grades[i] < 90)
                {
                    Console.WriteLine("This grade is a B.");
                    Console.Write(grades[i] + "\n");
                }
                else if (grades[i] >= 70 && grades[i] < 80)
                {
                    Console.WriteLine("This grade is a C.");
                    Console.Write(grades[i] + "\n");
                }
                else if (grades[i] >= 65 && grades[i] < 70)
            {
                    Console.WriteLine("This grade is a D.");
                    Console.Write(grades[i] + "\n");
                }
                else if (grades[i] >= 0 && grades[i] < 65)
                {
                    Console.WriteLine("This grade is a F.");
                    Console.Write(grades[i] + "\n");
                }
                else
                {
                    Console.WriteLine("This is out of the range of 0-100. How did that happen you Goose?");
                    Console.Write(grades[i] + "\n");
                }
            }

            //average calculation
            float average;
            int sum = 0;

            for (int i = 0; grades.Length > i; i++)
            {
                sum += grades[i];
            }

            average = sum/ grades.Length;

            Console.WriteLine("Average grade: " +  average);

            Console.WriteLine("All grades for " + studentName + " have been displayed. Cheers :)");

        }
    }
}
