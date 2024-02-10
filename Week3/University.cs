using System;

namespace Week3.Task1
{
    class University
    {
        private string[] faculty;
        private int numberOfStudents;

        public University(string[] faculty, int numberOfStudents)
        {
            this.faculty = faculty;
            this.numberOfStudents = numberOfStudents;
        }

        public string[] Faculty
        {
            get { return faculty; }
            set { faculty = value; }
        }

        public int NumberOfStudents
        {
            get { return numberOfStudents; }
            set { numberOfStudents = value; }
        }

        public void AddStudents(int newStudents)
        {
            numberOfStudents += newStudents;
        }

        public void RemoveStudents(int removedStudents)
        {
            numberOfStudents -= removedStudents;
            if (numberOfStudents < 0)
            {
                numberOfStudents = 0;
            }
        }

        public void AddFaculty(string newFaculty)
        {
            string[] newFaculties = new string[faculty.Length + 1];
            Array.Copy(faculty, newFaculties, faculty.Length);
            newFaculties[newFaculties.Length - 1] = newFaculty;
            faculty = newFaculties;

            Console.WriteLine("List of all faculties:");
            foreach (string fac in faculty)
            {
                Console.WriteLine(fac);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string[] initialFaculty = { "Computer Science", "Mathematics", "Physics" };
            University university = new University(initialFaculty, 100);

            Console.WriteLine("Welcome to the University");

            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("\nChoose an option:");
                Console.WriteLine("1. Add students");
                Console.WriteLine("2. Remove students");
                Console.WriteLine("3. Add faculty");
                Console.WriteLine("4. Exit");

                // Below line reads a line of text input from the console, tries to parse it as an integer, and 'out' stores the parsed integer into the variable choice. If the parsing is successful, the condition evaluates to true, and if it fails, the condition evaluates to false.

                if (int.TryParse(Console.ReadLine(), out int choice))
                {
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Enter the number of students to add:");
                            int newStudents = int.Parse(Console.ReadLine());
                            university.AddStudents(newStudents);
                            Console.WriteLine($"Total number of students after addition: {university.NumberOfStudents}");
                            break;

                        case 2:
                            Console.WriteLine("Enter the number of students to remove:");
                            int removedStudents = int.Parse(Console.ReadLine());
                            university.RemoveStudents(removedStudents);
                            Console.WriteLine($"Total number of students after removal: {university.NumberOfStudents}");
                            break;

                        case 3:
                            Console.WriteLine("Enter the name of the new faculty:");
                            string newFaculty = Console.ReadLine();
                            Console.WriteLine("Faculty added successfully.");
                            university.AddFaculty(newFaculty);
                            break;

                        case 4:
                            exit = true;
                            break;

                        default:
                            Console.WriteLine("Invalid choice! Please enter a valid option.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input! Please enter a valid option number.");
                }
            }

            Console.WriteLine("Thank you!");
        }
    }
}