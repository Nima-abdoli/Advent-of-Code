using System;
using System.IO;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] input;
            int floor = 0;
            string inputtext;
            string filepath ="Input Day01-1.txt";

            Console.WriteLine("Reading input ...");
            inputtext = File.ReadAllText(filepath);

            input = inputtext.ToCharArray();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(')
                {
                    floor++;
                }
                else
                {
                    floor--;
                }

                if (floor == -1)
                {
                    System.Console.WriteLine("position of character is : {0}", i+1); // answer is 1771.
                    return;
                }
            }
        }
    }
}