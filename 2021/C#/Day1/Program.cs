using System;
using System.IO;
using System.Collections;

namespace day1{
    static public class program{

        

        static void Main()
        {
            int count = 0;
            //int startfrom = 0;
            int NowSum = 0;
            int PastSum = 0;

            string[] text = File.ReadAllLines(@"C:\Users\Xmasta\Desktop\Advent of Code\Day1\input2.txt");

            System.Console.WriteLine(" text "+text.Length);

            int[] input = new int[text.Length];

            for (int i = 0; i < text.Length; i++)
            {
                input[i] = int.Parse(text[i]);
            }

            for (int i = 0; i < input.Length-2; i++)
            {
                NowSum = input[i] + input[i+1] + input[i+2]; 

                if (PastSum < NowSum && PastSum !=0)
                {
                    count++;
                    PastSum = NowSum;
                }else
                {
                    PastSum = NowSum;
                }
                
            }
            

            System.Console.WriteLine(count);
        }
    }
}


