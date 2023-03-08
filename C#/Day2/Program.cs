using System;
using System.IO;
using System.Collections;

namespace Day2
{
    class Program
    {
 
        static int depth = 0;
        static int Horizental = 0;  
        static int aim = 0;
        static string[] InputTxt;
        static string[] SepratedText;

        static void Main(string[] args)
        {
            Console.Clear();
            InputTxt = File.ReadAllLines(@"C:\Users\Xmasta\Desktop\Advent of Code\Day2\input.txt");

            System.Console.WriteLine(" Input : " + InputTxt.Length);
            
            foreach (string item in InputTxt)
            {
                SepratedText = item.Split(" ",2);
                System.Console.WriteLine("{0} - {1}",SepratedText[0],SepratedText[1]);
                switch (SepratedText[0])
                {
                    case "forward" : 
                    Horizental += int.Parse(SepratedText[1]);
                    depth += int.Parse(SepratedText[1]) * aim ;
                    break;

                    case "up" :
                    aim -= int.Parse(SepratedText[1]);
                    break;

                    case "down":
                    aim += int.Parse(SepratedText[1]);
                    break;
                }
            }
            System.Console.WriteLine("--------------------------------------------");
            System.Console.WriteLine(aim);
            System.Console.WriteLine("Depth : {0} | horizental : {1} <> multiply : {2}",depth, Horizental, depth * Horizental);
            
        }
    }
}
