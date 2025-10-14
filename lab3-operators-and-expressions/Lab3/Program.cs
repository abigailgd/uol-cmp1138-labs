internal class Program
{
    private static void Main(string[] args)
    {
        // Task 1: Arithmetic Playground
        /*
        Console.Write("Enter first number: ");
        int a = int.Parse(Console.ReadLine()!);
        Console.Write("Enter second number: ");
        int b = int.Parse(Console.ReadLine()!);

        Console.WriteLine($"\nSum: {a + b}");
        Console.WriteLine($"Difference: {a - b}");
        Console.WriteLine($"Product: {a * b}");
        Console.WriteLine($"Quotient: {a / b}");
        Console.WriteLine($"Remainder: {a % b}");
        Console.WriteLine($"Average: {(a + b) / 2}");
        */

        // Task 2: VAT & Final Price Calculator
        /*
        Console.Write("Enter item price (£): ");
        decimal price = decimal.Parse(Console.ReadLine()!);
        Console.Write("Enter VAT rate (%): ");
        decimal vat = decimal.Parse(Console.ReadLine()!);

        decimal addedvat = price * (vat / 100);
        Console.WriteLine($"VAT amount: £{addedvat:F2}");
        Console.WriteLine($"Final price: £{price + addedvat:F2}");
        */

        // Task 3: Membership Eligibility Checker
        /*
        Console.WriteLine("=== Gym Membership Eligibility Test ===");
        Console.Write("Enter age: ");
        int age = int.Parse(Console.ReadLine()!);
        Console.Write("Enter membership years: ");
        int membershipDuration = int.Parse(Console.ReadLine()!);

        Console.WriteLine($"\nStandard access (18-65): {age >= 18 && age <= 65}");
        Console.WriteLine($"Premium access (senior OR loyal): {age > 60 || membershipDuration > 5}");
        Console.WriteLine($"Not underage: {!(age < 18)}");
        */

        // Task 4: Monthly Salary Breakdown
        /*
        Console.WriteLine("=== Payroll Calculator ===");
        Console.Write("Enter base salary (£): ");
        decimal salary = decimal.Parse(Console.ReadLine()!);
        Console.Write("Enter bonus rate (%): ");
        decimal bonusRate = decimal.Parse(Console.ReadLine()!);
        Console.Write("Enter tax deduction (£): ");
        decimal tax = decimal.Parse(Console.ReadLine()!);
        Console.Write("Enter pension contribution (£): ");
        decimal pension = decimal.Parse(Console.ReadLine()!);

        decimal bonus = salary * (bonusRate / 100);
        decimal gross = salary + bonus;
        decimal net = gross - (tax + pension);

        Console.WriteLine($"\nBase Salary\t: £{salary:F2}");
        Console.WriteLine($"Bonus ({bonusRate}%)\t: £{bonus:F2}");
        Console.WriteLine($"Gross Salary\t: £{gross:F2}");
        Console.WriteLine($"Tax + Pension\t: £{tax + pension:F2}");
        Console.WriteLine($"Net Salary\t: £{net:F2}");
        */

        // Task 5: Student Performance Evaluator
        /*
        Console.WriteLine("=== Student Performance Evaluator ===");
        Console.Write("Enter mark 1: ");
        int m1 = int.Parse(Console.ReadLine()!);
        Console.Write("Enter mark 2: ");
        int m2 = int.Parse(Console.ReadLine()!);
        Console.Write("Enter mark 3: ");
        int m3 = int.Parse(Console.ReadLine()!);

        double average = (m1 + m2 + m3) / 3.0;

        Console.WriteLine($"\nAverage: {average:F2}");
        Console.WriteLine($"Distinction: {average >= 70}");
        Console.WriteLine($"Pass: {average >= 40 && average < 70}");
        Console.WriteLine($"Fail: {average < 40}");
        */

        // Task 6: Bug Hunt — Fix the Program
        /*
        // Fixed version
        Console.WriteLine("=== Cinema Kiosk ===");
        Console.Write("Ticket price (£): ");
        decimal ticketPrice = decimal.Parse(Console.ReadLine()!);
        Console.Write("Number of tickets: ");
        int ticketCount = int.Parse(Console.ReadLine()!);
        Console.Write("Snack price (£): ");
        decimal snackPrice = decimal.Parse(Console.ReadLine()!);
        Console.Write("Number of snacks: ");
        int snackCount = int.Parse(Console.ReadLine()!);
        Console.Write("Voucher tokens: ");
        int tokens = int.Parse(Console.ReadLine()!);
        Console.Write("Student (true/false): ");
        bool isStudent = bool.Parse(Console.ReadLine()!);

        decimal ticketSub = ticketPrice * ticketCount;
        decimal snackSub = snackPrice * snackCount;
        Console.WriteLine($"Ticket subtotal: £{ticketSub:F2}");

        int freeSnacks = tokens / 3;
        snackSub -= snackPrice * freeSnacks;
        int leftoverTokens = tokens % 3;

        decimal vatRate = 20m / 100m;
        decimal vat = (ticketSub + snackSub) * vatRate;
        decimal totalDue = (ticketSub + snackSub) + vat;

        Console.WriteLine("\n--- Bill ---");
        Console.WriteLine($"Tickets : {ticketCount} @ £{ticketPrice:F2}");
        Console.WriteLine($"Snacks : {snackCount} @ £{snackPrice:F2}");
        Console.WriteLine($"Free snacks from tokens: {freeSnacks}, leftover: {leftoverTokens}");
        Console.WriteLine($"VAT (20%): £{vat:F2}");
        Console.WriteLine($"TOTAL: £{totalDue:F2}");
        */

        // Stretch Task: Vending Machine System
        // • Assume the user pays enough.
        // • Output limits to UK coins (£2, £1, 50p, 20p, 10p, 5p, 2p, 1p).
        int[] coinAmounts = { 200, 100, 50, 20, 10, 5, 2, 1 };
        int[] coins = { 0, 0, 0, 0, 0, 0, 0, 0 };

        Console.Write("Item price (£): ");
        decimal itemPrice = decimal.Parse(Console.ReadLine()!);
        Console.Write("Amount paid (£): ");
        decimal paid = decimal.Parse(Console.ReadLine()!);

        decimal changeDue = paid - itemPrice;
        int changeInPence = (int)(changeDue * 100);

        for (int i = 0; i < coinAmounts.Length; i++)
        {
            int count = changeInPence / coinAmounts[i];
            changeInPence -= count * coinAmounts[i];
            coins[i] = count;
        }

        Console.WriteLine($"\nChange due\t:\t£{changeDue:F2}");

        for (int i = 0; i < coins.Length; i++)
        {
            string coinName = $"{coinAmounts[i]}p";
            if (coinAmounts[i] >= 100)
            {
                coinName = $"£{coinAmounts[i] / 100}";
            }

            Console.WriteLine($"{coinName} count\t:\t{coins[i]}");
        }
    }
}


