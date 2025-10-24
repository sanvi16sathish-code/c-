using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Armstrong numbers between 1 and 1000:");

        for (int num = 1; num <= 1000; num++)
        {
            int sum = 0;
            int temp = num;
            int digits = num.ToString().Length;

            while (temp > 0)
            {
                int digit = temp % 10;
                sum += (int)Math.Pow(digit, digits);
                temp /= 10;
            }

            if (sum == num)
            {
                Console.WriteLine(num);
            }
        }
    }
}