internal class Program
{
    private static void Main(string[] args)
    {
        // Task 1: Recording Daily Temperatures (Arrays)
        /*
        double[] temperatures = new double[7];
        for(int i = 0; i < temperatures.Length; i++)
        {
            Console.Write($"Enter temperature for day {i+1}: ");

            double tempInputValue = double.Parse(Console.ReadLine()!);
            temperatures[i] = tempInputValue;
        }

        Console.Write("Temperatures: ");
        for(int i = 0; i < temperatures.Length; i++)
        {
            Console.Write($"{temperatures[i]}");
            if(i != temperatures.Length - 1) Console.Write($", ");
            else Console.Write("\n");
        }

        double avg = 0;
        double highest = Double.MinValue;
        double lowest = Double.MaxValue;
        foreach(double t in temperatures)
        {
            avg += t;
            if(t > highest) highest = t;
            if(t < lowest) lowest = t;
        }

        avg = avg / temperatures.Length;

        Array.Sort(temperatures);
        Console.Write("Sorted Temperatures: ");
        for(int i = 0; i < temperatures.Length; i++)
        {
            Console.Write($"{temperatures[i]}");
            if(i != temperatures.Length - 1) Console.Write($", ");
            else Console.Write("\n");
        }

        Console.WriteLine($"Average: {avg}");
        Console.WriteLine($"Highest: {highest}");
        Console.WriteLine($"Lowest: {lowest}");
        */

        // Task 2: Student Scores Report (Arrays)
        /*
        int[] scores = {6, 4, 3, 5, 7};
        double avg = 0;

        Console.Write("Scores: ");
        for(int i = 0; i < scores.Length; i++)
        {
            Console.Write($"{scores[i]}");
            if(i != scores.Length - 1) Console.Write($", ");
            else Console.Write("\n");

            avg += scores[i];
        }

        avg = avg / scores.Length;
        Array.Reverse(scores);

        Console.WriteLine($"Average: {avg}");
        Console.Write("Reversed scores: ");
        for(int i = 0; i < scores.Length; i++)
        {
            Console.Write($"{scores[i]}");
            if(i != scores.Length - 1) Console.Write($", ");
            else Console.Write("\n");

            avg += scores[i];
        }

        Console.Write($"Enter score to search for: ");
        int index = Array.IndexOf(scores, int.Parse(Console.ReadLine()!));

        if(index != -1)
        {
            Console.WriteLine($"Score is at {index}.");
        } else {
            Console.WriteLine("Score not found.");
        }
        */

        // Task 3: Shopping List Manager (Lists)
        /*
        List<string> shoppingList = new List<string>();
        while(true)
        {
            Console.Write("Enter item name or type \"end\" to stop: ");
            string input = Console.ReadLine()!;

            if(input == "end") break;
            else shoppingList.Add(input);
        }

        Console.WriteLine("Shopping list:");
        foreach(string item in shoppingList)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine($"\nRemoved {shoppingList[0]}");
        shoppingList.Remove(shoppingList[0]);

        Console.WriteLine("\nShorter shopping list:");
        foreach(string item in shoppingList)
        {
            Console.WriteLine(item);
        }

        shoppingList.Sort();

        Console.WriteLine("\nSorted shopping list:");
        foreach(string item in shoppingList)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine($"Shopping list has {shoppingList.Count} items.");
        */

        // Task 4: Customer Order System (Lists)
        List<string> items = new List<string>();
        List<double> prices = new List<double>();

        while(true)
        {
            Console.Write("Enter item name or type \"done\" to stop: ");
            string itemsInput = Console.ReadLine()!;

            if(itemsInput == "done") break;
            else items.Add(itemsInput);

            Console.Write("Enter item price: ");
            double priceInput = double.Parse(Console.ReadLine()!);

            prices.Add(priceInput);
        }

        double totalPrice = 0;
        for(int i = 0; i < items.Count; i++)
        {
            Console.WriteLine($"{items[i]} @ £{prices[i]:F2}");
            totalPrice += prices[i];
        }
        Console.WriteLine($"Total price: £{totalPrice:F2}");

        List<string> sortedItems = new List<string>();
        List<double> sortedPrices = new List<double>(prices);

        sortedPrices.Sort();

        foreach(double price in sortedPrices)
        {
            int index = prices.IndexOf(price);
            sortedItems.Add(items[index]);
            items.RemoveAt(index);
            prices.RemoveAt(index);
        }

        Console.WriteLine("\nSorted");
        double sortedTotalPrice = 0;
        double highest = Double.MinValue;
        double lowest = Double.MaxValue;
        for(int i = 0; i < sortedItems.Count; i++)
        {
            Console.WriteLine($"{sortedItems[i]} @ £{sortedPrices[i]:F2}");
            sortedTotalPrice += sortedPrices[i];

            if(sortedPrices[i] > highest) highest = sortedPrices[i];
            if(sortedPrices[i] < lowest) lowest = sortedPrices[i];
        }
        Console.WriteLine($"Total price: £{totalPrice:F2}");

        Console.WriteLine($"\nHighest: £{highest:F2}, Lowest: £{lowest:F2}.");
    }
}