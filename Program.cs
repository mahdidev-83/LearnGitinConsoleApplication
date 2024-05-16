using System;

namespace LearnGitinConsoleapplication
{
    public class LearnGitinConsoleapplication
    {
        public static void Main(String[] args)
        {
            string String1 = "Hello World";
            Console.WriteLine(String1);
            

            // the sum of two numbers:
            Console.WriteLine(sum(1, 2)); // the sum of 1 + 2 = 3;
            Console.ReadLine();
        }

        public string saymyname(string name)
        {
            return $"my name is {name}";
        }

        // the sum of two numbers in the program.cs but in the (SUM) branch!
        public static int sum(int m, int n)
        {
            return m + n;
        }
        
    }
}