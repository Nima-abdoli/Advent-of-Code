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

            foreach (char i in input)
            {
                if (i == '(')
                {
                    floor++;
                }else
                {
                    floor--;
                }
            }

            Console.WriteLine("Santa is in Floor : {0}",floor); // Answer is '138'
        }
    }
}