using System;

namespace PalindromeString;

public static class Program
{
    public static void Main(string[] args)
    {
        if (args == null)
        {
            throw new ArgumentNullException(nameof(args));
        }

        Console.WriteLine("Enter a string : ");

        string input = Console.ReadLine() ?? string.Empty;

        char[] firstString = input.ToCharArray();

        Array.Reverse(firstString);

        string reverseString = new(firstString);

        if (input == reverseString)
        {
            Console.WriteLine($"{input} reversed is {reverseString}: This word is a Palindrome!");
        }

        else
        {
            Console.WriteLine($"{input} reversed is {reverseString}: This word is not a Palindrome!");
        }
    }
}
