using Microsoft.VisualBasic;

namespace grade_calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Maxwell Sigrest
            IGME 201 - 8-9:15
            Due October 13, 2024*/

            string stuName = "Max";
            int average = 0;
            int[] grades = new int[10];
            grades[0] = 100;
            grades[1] = 92;
            grades[2] = 87;
            grades[3] = 200;
            grades[4] = -20;
            grades[5] = 52;
            grades[6] = 82;
            grades[7] = 75;
            grades[8] = 67;
            grades[9] = 88;

            Console.WriteLine("Hello there student, whose name is " + stuName + "!");
            Console.WriteLine("Here are your grades: ");
            for (int i = 0; i < grades.Length; i++)
            {
                Console.Write("You recieved a " + grades[i] + ".");
                average += grades[i];

                if (grades[i] <= 100 && grades[i] >= 90)
                {
                    if (grades[i] == 100)
                    {
                        Console.WriteLine("WOW! A perfect score!");
                    }
                    else
                    {
                        Console.WriteLine("This grade is an A!");
                    }
                }
                else if (grades[i] <= 89 && grades[i] >= 80)
                {
                    Console.WriteLine("This grade is an B.");
                }
                else if (grades[i] <= 79 && grades[i] >= 70)
                {
                    Console.WriteLine("This grade is an C.");
                }
                else if (grades[i] <= 69 && grades[i] >= 65)
                {
                    Console.WriteLine("This grade is an D.");
                }
                else if (grades[i] <= 64 && grades[i] >= 0)
                {
                    Console.WriteLine("This grade is an F.");
                }
                else
                {
                    Console.WriteLine("How did you even get this grade?");
                }
            }

            average = average / grades.Length;
            Console.WriteLine("Your average is: " + average);
            Console.WriteLine("We have calculated all grades for " + stuName);
        }
    }
}
