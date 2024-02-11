using System;
namespace Week4.Task1
{
    public class LibraryItem
    {
        public int id;
        public string title;
        public bool isCheckedOut;

        public LibraryItem(int id, string title)
        {
            this.id = id;
            this.title = title;
            this.isCheckedOut = false;
        }

        public void DisplayInfo()
        {
            Console.WriteLine("ID: " + id);
            Console.WriteLine("Title: " + title);
            Console.WriteLine("Is Checked Out: " + (isCheckedOut ? "Yes" : "No"));
        }

        public void CheckOut()
        {
            if (!isCheckedOut)
            {
                isCheckedOut = true;
                Console.WriteLine("Item checked out successfully.");
            }
            else
            {
                Console.WriteLine("Item is already checked out.");
            }
        }

        public void ReturnItem()
        {
            if (isCheckedOut)
            {
                isCheckedOut = false;
                Console.WriteLine("Item returned successfully.");
            }
            else
            {
                Console.WriteLine("Item is not checked out.");
            }
        }
    }

    public class Book : LibraryItem
    {
        public string author;
        public int pages;

        public Book(int id, string title, string author, int pages) : base(id, title)
        {
            this.author = author;
            this.pages = pages;
        }

        public new void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine("Author: " + author);
            Console.WriteLine("Pages: " + pages);
        }
    }

    public class DVD : LibraryItem
    {
        public string director;
        public int duration;

        public DVD(int id, string title, string director, int duration) : base(id, title)
        {
            this.director = director;
            this.duration = duration;
        }

        public new void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine("Director: " + director);
            Console.WriteLine("Duration: " + duration + " minutes");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create instances
            Book book1 = new Book(1, "Rich Dad Poor Dad", "Robert T. Kiyosaki", 180);
            DVD dvd1 = new DVD(2, "Theory Of Everything", "James Marsh", 86);

            // Run until exit
            bool exit = false;
            while (!exit)
            {
                // Prompt user for input
                Console.WriteLine("1. Book info");
                Console.WriteLine("2. DVD info");
                Console.WriteLine("3. Checkout");
                Console.WriteLine("4. Return");
                Console.WriteLine("5. Exit");
                string choice = Console.ReadLine();
                Console.WriteLine();

                switch (choice)
                {
                    case "1":
                        book1.DisplayInfo();
                        break;
                    case "2":
                        dvd1.DisplayInfo();
                        break;
                    case "3":
                        Console.WriteLine("Enter the ID of the item you want to check out:");
                        int itemId = Convert.ToInt32(Console.ReadLine());
                        if (itemId == book1.id)
                        {
                            book1.CheckOut();
                        }
                        else if (itemId == dvd1.id)
                        {
                            dvd1.CheckOut();
                        }
                        else
                        {
                            Console.WriteLine("Item not found.");
                        }
                        break;
                    case "4":
                        Console.WriteLine("Enter the ID of the item you want to return:");
                        itemId = Convert.ToInt32(Console.ReadLine());
                        if (itemId == book1.id)
                        {
                            book1.ReturnItem();
                        }
                        else if (itemId == dvd1.id)
                        {
                            dvd1.ReturnItem();
                        }
                        else
                        {
                            Console.WriteLine("Item not found.");
                        }
                        break;
                    case "5":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
        }
    }
}