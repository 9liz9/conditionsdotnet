namespace S02_conditions;

class Program
{
    static void Main(string[] args)
    {
           int minimum, maximum;

        Console.Write("Limit1: ");
        minimum = int.Parse(Console.ReadLine());

        Console.Write("Limit2: ");
        maximum = int.Parse(Console.ReadLine());

        Console.Write("Integer: ");
        int value = int.Parse(Console.ReadLine());

        if (value > maximum)
        {
            Console.WriteLine($"You have entered {value} which is greater than {maximum} which is the maximum");
            value = maximum;
        }
        else if (value < minimum)
        {
            Console.WriteLine($"You have entered {value} which is lower than {minimum} which is the minimum");
            value = minimum;
        }

        Console.WriteLine($"Resulting integer: {value}");
    }

}

