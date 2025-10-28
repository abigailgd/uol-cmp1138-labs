internal class Program 
{
    private static void Main(string[] args)
    {
        // Task 1: A simple while loop
        /*
        int counter = 1;
        while (counter <= 5)
        {
            Console.Write(counter);
            counter++;
        }
        */

        // Task 2: Price chart
        /*
        int quantity = 10;
        Console.WriteLine("Widget Quantity\t\tPrice");

        while(quantity <= 100)
        {
            decimal price;

            if(quantity <= 50) price = 5m*(decimal)quantity;
            else if(quantity <= 80) price = 4m*(decimal)quantity;
            else price = 2.50m*(decimal)quantity;

            Console.WriteLine($"\t{quantity}\t\t£{price:F2}");

            quantity += 10;
        }

        // Task 3: Task 2 extension using a do… while loop
        string choice = "";

        do
        {
            decimal price;

            Console.Write("Input a number of widgets: ");
            int input = int.Parse(Console.ReadLine()!);

            if(input <= 50) price = 5m*(decimal)input;
            else if(input <= 80) price = 4m*(decimal)input;
            else price = 2.50m*(decimal)input;

            Console.WriteLine("Widget Quantity\t\tPrice");
            Console.WriteLine($"\t{input}\t\t£{price:F2}");

            Console.WriteLine("Would you like to check another or quit? (y/q) ");
            choice = Console.ReadLine()!;
        } while (choice != "q" && choice != "Q");
        */

        // Task 4: Sum of Numbers (1–N) using for loop
        /*
        Console.Write("Enter N: ");
        int n = int.Parse(Console.ReadLine()!);
        int sum = 0;

        for(int i = 0; i <= n; i++)
        {
            sum += i;
        }
        
        Console.WriteLine($"Sum = {sum}");
        */

        // Task 5: Factorial calculator using for loop
        /*
        Console.Write("Enter n: ");
        int n = int.Parse(Console.ReadLine()!);
        int fact = 1;

        for(int i = 1; i <= n; i++)
        {
            fact *= i;
        }
        
        Console.WriteLine($"n! = {fact}");
        */

        // Task 6: Star Pattern (Nested Loops)
        /*
        for(int i = 1; i <= 5; i++)
        {
            for(int x = 0; x < i; x++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }

        for(int i = 4; i >= 1; i--)
        {
            for(int x = 0; x < i; x++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
        */

        // Task 7: Space remover extension
        /*
        string myString = "your name here";
        string newString = "";
        int chars = 0;
        foreach (char c in myString)
        {
            if (c == ' ')
                continue;
            newString += c;
        }
        Console.WriteLine($"Without spaces: {newString}");
        foreach (char c in newString)
        {
            chars++;
        }

        Console.WriteLine($"There are {chars} characters.");
        */

        // Stretch Task 1: Guess the Number Game
        /*
        Random rnd = new Random();
        int num = rnd.Next(1, 21);
        int guess = 0;

        Console.WriteLine("I'm thinking of a number between 1 and 20...");
        while(guess != num)
        {
            Console.Write("Enter your guess: ");
            guess = int.Parse(Console.ReadLine()!);

            if(guess < num) Console.WriteLine("Too low");
            else if(guess > num) Console.WriteLine("Too high");
            else if(guess == num) break;
        }
        Console.WriteLine("Correct! Well done!");
        */

        // Stretch Task 2: Blackjack challenge!
        Random rnd = new Random();
        int p1Total = 0;
        bool p1Pause = false;
        int p2Total = 0;
        bool p2Pause = false;

        int turn = 1;
        int round = 1;
        int change = 0;
        string decision = "";

        while(p1Total <= 21 && p2Total <= 21)
        {
            Console.WriteLine($"\nP1: {p1Total}, P2: {p2Total}.");
            Console.WriteLine($"Player {turn}'s turn.");

            if(round == 1) { 
                decision = "Draw";
            } else if (turn == 1 && !p1Pause || turn == 2 && !p2Pause) {
                Console.Write("Draw? (true/false) ");
                bool draw = bool.Parse(Console.ReadLine()!);
                if(draw) { decision = "Draw"; }
                else { decision = "Halt"; }
            } else {
                decision = "Skip";
            }

            if(decision == "Draw") { 
                Console.WriteLine("DRAW!");
                change = rnd.Next(1, 12);

                if(turn == 1) 
                {
                    p1Total += change;
                    turn++;
                } else if (turn == 2) {
                    p2Total += change;
                    turn = 1;
                    round++;
                }
            }
            else if(decision == "Halt")
            {
                Console.WriteLine("Pass.");
                if(turn == 1)
                {
                    p1Pause = true;
                    turn++;
                } else if (turn == 2) {
                    p2Pause = true;
                    turn = 1;
                    round++;
                }
            }
            else if(decision == "Skip")
            {
                if(turn == 1) {
                    p1Pause = false;
                    turn++;
                } else if (turn == 2) {
                    p2Pause = false;
                    turn = 1;
                    round++;
                }
            }

            if(p1Pause && p2Pause)
            {
                break;
            }
        }

        Console.WriteLine($"\nP1: {p1Total}, P2: {p2Total}.");
        if(p1Total > 21)
        {
            Console.WriteLine("Player 2 wins!");
        }
        else if(p2Total > 21)
        {
            Console.WriteLine("Player 1 wins!");
        }
        else if(21 - p2Total < 21 - p1Total)
        {
            Console.WriteLine("Player 2 wins!");
        }
        else if(21 - p1Total < 21 - p2Total)
        {
            Console.WriteLine("Player 1 wins!");
        }
    }
}

