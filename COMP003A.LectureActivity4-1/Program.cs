/*
 Author: Victor Flores
Course: COMP003A
Faculty: Jonathon Cruz
Purpose: Calculate average grades using arrays and list in C#*/namespace COMP003A.LectureActivity4_1
{
    internal class Program
    {
        static void Main(string[] args)
            
        {
            int[] grades = new int [5];//the array for 5 grades
            
            for (int i = 0; i < grades.Length; i++)
            {
                int grade = -1;//initialize with an invalid vcalue to ensure validation starts
                while (grade < 0 || grade > 100)
                {
                    Console.WriteLine($"Enter grade for student {i + 1} (0-100): ");
                    if (int.TryParse(Console.ReadLine(), out grade))// check if input is a valid integer
                    {
                        if (grade >= 0 && grade <= 100)
                        {
                            grades[i] = grade;
                        }
                        else
                        {
                            Console.WriteLine("Grade must be between 0 and 100)");
                    }   }
                    else 
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number.");
                        grade = -1;//reset grade to an invalid value to re-enter loop
                    }
                }
            }        
            
        }
    }
}
