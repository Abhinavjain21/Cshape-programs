using System;
using System.Text;

class Program
{
    static int SumNumbersInString(string input)
    {
        int sum = 0;
        StringBuilder currentNumber = new StringBuilder();

        foreach (char c in input)
        {
            if (char.IsDigit(c))
            {
                currentNumber.Append(c);
            }
            else if (currentNumber.Length > 0)
            {
                sum += int.Parse(currentNumber.ToString());
                currentNumber.Clear();
            }
        }

        if (currentNumber.Length > 0)
        {
            sum += int.Parse(currentNumber.ToString());
        }

        return sum;
    }

    static void Main()
    {
        Console.WriteLine("enter a String");
        string input = Console.ReadLine();

        int sum = SumNumbersInString(input);

        Console.WriteLine("Sum of numbers in the string: " + sum);
        Console.ReadLine();
    }
}
