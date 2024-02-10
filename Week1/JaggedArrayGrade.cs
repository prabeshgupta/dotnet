// 5. Implement a C# program to store and display the grades of students in different subjects. Use a jagged array where each student has a variable number of grades in different subjects. The program should do the following:
// 1. Initialize a jagged array to store grades for three students.
// 2. Allow the user to input the number of subjects and grades for each student.
// 3. Calculate and display the average grade for each student.
// 4. Determine and display the highest grade among all students.

using System;

namespace Week1.Task5;
class JaggedArrayGrade
{
    static void Main(string[] args)
    {
        // Initialize a jagged array to store grades for three students
        double[][] grades = new double[3][];

        // Allow the user to input the number of subjects and grades for each student
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine($"Enter the number of subjects for student {i + 1}:");
            int numSubjects = int.Parse(Console.ReadLine());

            grades[i] = new double[numSubjects];

            Console.WriteLine($"Enter the grades for student {i + 1}:");
            for (int j = 0; j < numSubjects; j++)
            {
                Console.Write($"Grade {j + 1}: ");
                grades[i][j] = double.Parse(Console.ReadLine());
            }
        }

        // Calculate and display the average grade for each student
        for (int i = 0; i < 3; i++)
        {
            double sum = 0;
            foreach (double grade in grades[i])
            {
                sum += grade;
            }
            double average = sum / grades[i].Length;

            // :F2 is a format specifier that tells C# to format the average value as a fixed-point number with two decimal places.
            Console.WriteLine($"Average grade for student {i + 1}: {average:F2}");
        }

        // Determine and display the highest grade among all students
        double highestGrade = double.MinValue;
        foreach (double[] studentGrades in grades)
        {
            foreach (double grade in studentGrades)
            {
                if (grade > highestGrade)
                {
                    highestGrade = grade;
                }
            }
        }
        Console.WriteLine($"Highest grade among all students: {highestGrade}");
    }
}
