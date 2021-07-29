using System;

namespace CountDigitsAndAlphabets
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            int alphabet, digit, i, l;
            alphabet = digit = i = l = 0;
            Console.WriteLine("Enter a string");
            str = Console.ReadLine();
            l = str.Length;

            while (i < l)
            {
                if ((str[i] >= 'a' && str[i] <= 'z') || (str[i] >= 'A' && str[i] <= 'Z')) 
                {
                    alphabet++;
                } else if(str[i] >='0' && str[i] <='9')
                {
                    digit++;
                }
                i++;
            }
            Console.WriteLine("Alphabets: {0}", alphabet);
            Console.WriteLine("Digits: {0}", digit);
        }
    }
}
