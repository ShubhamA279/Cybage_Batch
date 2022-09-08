using System;


namespace Day_02_Sept06
{
    internal class Input_User
    {
        static void Main(string[] args)
        {
            int n1 = 20, n2 = 5;
            int sum = n1 + n2;
            int mul = n1 * n2;
            int div = n1 / n2;
            int sub = n1 - n2;
            int mod = n1 % n2;

            Console.WriteLine($"addition is : {sum}");
            Console.WriteLine($"multiplication is : {mul}");
            Console.WriteLine($"division is : {div}");
            Console.WriteLine($"subtraction is : {sub}");
            Console.WriteLine($"remainder is : {mod}");
        }
    }
}
