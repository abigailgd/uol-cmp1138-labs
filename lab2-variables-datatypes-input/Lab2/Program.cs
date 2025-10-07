internal class Program
{
    private static void Main(string[] args)
    {
        // Task 1: Data Type Sampler — Declare & Display
        /*
        int count = 12; // No decimal so no floating point needed
        double pi = 3.14159; // Decimal point but not financial so less precision needed than decimal
        decimal price = 10.99m; // Financial so precision needed
        char initial = 'A'; // Only one character so char not string
        string course = "Foundations of Programming"; // Whole string of text so string must be used
        bool student = true; // true or false value so bool

        Console.WriteLine($"Count: {count}");
        Console.WriteLine($"Pi: {pi}");
        Console.WriteLine($"Price: £{price:F2}");
        Console.WriteLine($"Initial: {initial}");
        Console.WriteLine($"Course: {course}");
        Console.WriteLine($"Student: {student}");
        */

        // Task 2: Convert Input — Profile Card
        /*
        Console.Write("What is your name? ");
        string name = Console.ReadLine()!;
        Console.Write("What is your age? ");
        int age = Convert.ToInt32(Console.ReadLine()!);
        Console.Write("Are you a student? (true/false) ");
        bool studentStatus = bool.Parse(Console.ReadLine()!);
        Console.Write("What is the ticket price? ");
        decimal ticketPrice = decimal.Parse(Console.ReadLine()!);
        Console.WriteLine($"Name: {name} | Age: {age} | Student: {studentStatus} | Price: £{ticketPrice:F2}");
        */

        // Task 3: Strings & Escape Sequences — Mini Receipt
        /*
        string item = "Guidebook";
        decimal price = 12.50m;
        string shop = "Museum Shop";

        Console.WriteLine($"===\t{shop} Receipt\t===\n\nItem: {item}\nPrice: \u00A3{price:F2}\nMessage: \"Thank you for visiting\"\nPath: C:\\Users\\Alex\\Documents\\Tickets\n\n===\t{shop} Receipt\t===");
        */

        // Task 4: Constants & Type Inference
        /*
        const string MuseumName = "National Museum";
        var header = $"=== {MuseumName} Ticket ===";
        Console.WriteLine(header);
        var today = DateTime.Now;
        Console.WriteLine($"Date: {today.Day:D2}/{today.Month:D2}/{today.Year} Time: {today.Hour:D2}:{today.Minute:D2} Day: {today.DayOfWeek}");
        */

        // Task 5: Formatting with Tabs — Neat Ticket Block
        /*
        Console.Write("What is your name? ");
        string name = Console.ReadLine()!;
        Console.Write("What is your age? ");
        int age = Convert.ToInt32(Console.ReadLine()!);
        Console.Write("Are you a student? (true/false) ");
        bool studentStatus = bool.Parse(Console.ReadLine()!);
        Console.Write("What is the ticket price? ");
        decimal ticketPrice = decimal.Parse(Console.ReadLine()!);
        Console.WriteLine($"Name\t:\t{name}\nAge\t:\t{age}\nStudent\t:\t{studentStatus}\nPrice\t:\t£{ticketPrice:F2}");
        */

        // Task 6: Bug Hunt — Fix the Program
        // Buggy program: fix me!
        /*
        Console.WriteLine("=== Ticket ===");
        string Name = "Alex";
        decimal price = 12.5m;
        Console.Write("Student (true/false): ");
        bool isStudent = bool.Parse(Console.ReadLine());
        Console.WriteLine($"Name: {Name}\nPrice: £{price:F2}\nStudent: {isStudent}");
        */

        // Stretch Task: Museum Ticket Printer
        Console.Write("What is your name? ");
        string name = Console.ReadLine()!;
        Console.Write("What is your age? ");
        int age = Convert.ToInt32(Console.ReadLine()!);
        Console.Write("Are you a student? (true/false) ");
        bool studentStatus = bool.Parse(Console.ReadLine()!);
        Console.Write("What is the ticket price? ");
        decimal ticketPrice = decimal.Parse(Console.ReadLine()!);

        Random rnd = new Random();
        int newRandom = rnd.Next(0, 9999);
        var today = DateTime.Now;
        string ticketID = $"LINC-{today.Year}-{newRandom:D4}";

        Console.WriteLine($"=== National Museum Ticket ===\nID\t:\t{ticketID}\nDate\t:\t{today.Day:D2}/{today.Month:D2}/{today.Year}\nName\t:\t{name}\nAge\t:\t{age}\nStudent\t:\t{studentStatus}\nPrice\t:\t£{ticketPrice:F2}\n------------------------------\nThank you for visiting the National Museum!\nPlease keep your ticket for same-day re-entry.");
    }
}