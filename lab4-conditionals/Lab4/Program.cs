internal class Program
{
    private static void Main(string[] args)
    {
        // Task 1: Even or Odd Checker
        /*
        Console.Write("Enter a number: ");
        int i = int.Parse(Console.ReadLine()!);

        if (i % 2 == 0) Console.WriteLine($"{i} is Even");
        else Console.WriteLine($"{i} is Odd");
        */

        // Task 2
        /*
        Console.Write("Enter temperature (*C): ");
        int i = int.Parse(Console.ReadLine()!);

        if (i < 10) Console.WriteLine("Too cold!");
        else if (i >= 10 && i <= 25) Console.WriteLine("Comfortable");
        else Console.WriteLine("Too hot!");
        */

        // Task 3: Eligibility & Nested Logic
        /*
        Console.Write("Enter age: ");
        int age = int.Parse(Console.ReadLine()!);
        Console.Write("Student (true/false): ");
        bool isStudent = bool.Parse(Console.ReadLine()!);

        if (age < 18 || isStudent || age >= 65) Console.WriteLine("Discount applies!");
        else Console.WriteLine("Standard ticket price.");
        */

        // Task 4: Grade Evaluator (Ternary Operator)
        /*
        Console.Write("Enter score: ");
        int score = int.Parse(Console.ReadLine()!);

        string result = score >= 40 ? "Pass" : "Fail";
        Console.WriteLine($"Result: {result}");
        */

        // Task 5: Menu System (Classic switch)
        /*
        Console.WriteLine("1. Tea\n2. Coffee\n3. Water\n4. Exit");
        Console.Write("Choose an option: ");
        int i = int.Parse(Console.ReadLine()!);

        switch (i)
        {
            case 1:
                Console.WriteLine("You selected Tea.");
                break;
            case 2:
                Console.WriteLine("You selected Coffee.");
                break;
            case 3:
                Console.WriteLine("You selected Water.");
                break;
            case 4:
                Console.WriteLine("Exiting.");
                break;
            default:
                Console.WriteLine("Invalid option!");
                break;
        }
        */

        // Task 6: Ticket Price Calculator
        /*
        Console.Write("Enter age: ");
        int age = int.Parse(Console.ReadLine()!);
        Console.Write("Student (true/false): ");
        bool isStudent = bool.Parse(Console.ReadLine()!);

        decimal ticketPrice = 10m;
        decimal discount = 0m;

        if (age < 18) discount = 0.5m;
        else if (age >= 65) discount = 0.3m;
        else if (isStudent) discount = 0.25m;

        ticketPrice *= 1m - discount;

        Console.WriteLine($"Discount: {discount*100:F0}%");
        Console.WriteLine($"Final price: £{ticketPrice:F2}");
        */

        // Stretch Task
        Console.Write("Enter suit (s/h/d/c): ");
        char suitValue = char.Parse(Console.ReadLine()!);
        Console.Write("Enter card (7-14): ");
        int cardValue = int.Parse(Console.ReadLine()!);

        string suitName = suitValue switch
        {
            's' => "Spades",
            'h' => "Hearts",
            'd' => "Diamonds",
            'c' => "Clubs",
            _ => throw new ArgumentException(),
        };

        string cardName = cardValue switch
        {
            7 => "Seven",
            8 => "Eight",
            9 => "Nine",
            10 => "Ten",
            11 => "Jack",
            12 => "Queen",
            13 => "King",
            14 => "Ace",
            _ => throw new ArgumentException(),
        };

        Console.WriteLine($"{cardName} of {suitName}");
    }
}