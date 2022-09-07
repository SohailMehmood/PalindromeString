using System;
using System.Linq;

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

        Console.WriteLine(firstString);

        Array.Reverse(firstString);

        string reverseString = new(firstString);

        Console.WriteLine(reverseString);

        if (input == reverseString)
        {
            Console.WriteLine("This word is a Palindrome!");
        }

        else
        {
            Console.WriteLine("This word is not a Palindrome!");
        }
    }
}
