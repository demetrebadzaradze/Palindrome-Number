//Palindrome Number
using System;
using System.Collections;

namespace Csharpproject
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            bool ispalindrome;

            Console.WriteLine("Enter number");
            num = Convert.ToInt32(Console.ReadLine());

            ispalindrome = IsPalindrome(num);

            if(ispalindrome == true)
            {
                Console.WriteLine($"{num} is palindrome num");
            }
            else
            {
                Console.WriteLine($"{num} is not palindrome num");
            }
            Console.WriteLine();
        }
        static bool IsPalindrome(int x)
        {
            bool result = false;
            string num = x.ToString();
            string reversedNum = null;

            if(x < 0)
            {
                return false;
            }

            for (int i = 0; i < num.Length; i++)
            {
                reversedNum = num[i] + reversedNum;
            }

            long n = Convert.ToInt64(reversedNum);

            if (n == x)
            {
                result = true;
            }

            return result;
        }
    }
}