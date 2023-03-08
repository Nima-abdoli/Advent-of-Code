using System;
using System.IO;
using System.Collections.Generic;

namespace day3
{
    class Program
    {
        static string[] Input;
        static List<string> OxgenHolder = new List<string>();
        static List<string> Co2Holder = new List<string>();

        static string GamaRate = "";
        static string EpsilonRate = "";
        static string OxGenRate = "";
        static string Co2ScrubRate = "";

        static int OneCount = 0;

        static int ZeroCount = 0;
        // Gama rate is most common bit
        static int GamaRateBin;
        // Epsilon rate is least bit
        static int EpsilonRatebin;

        static string g;

        static void Main(string[] args)
        {
            Input = File.ReadAllLines(@"C:\Users\Xmasta\Desktop\Advent of Code\day3\input.txt");

            for (int i = 0; i < 12; i++)
            {
                
                for (int y = 0; y < Input.Length; y++)
                {
                    g = Input[y];

                    Ratemaker(g.Substring(i, 1));
                }

                RateString();

            }
            ToDecimal();

            Console.WriteLine("\n Gama Rate : {0} ({1}) \n Epsilon Rate : {2} ({3}) ",GamaRate,GamaRateBin,EpsilonRate,EpsilonRatebin);
            Console.WriteLine(" Submarine power consumption : {0}", GamaRateBin * EpsilonRatebin);

            FindOxygenRate();

        }

        static void Ratemaker(string c)
        {
            switch (c)
            {
                case "0":
                    ZeroCount++;
                    break;
                case "1":
                    OneCount++;
                    break;
            }
        }

        static void RateString()
        {
            if (OneCount > ZeroCount)
            {
                GamaRate += "1";
                EpsilonRate += "0";
            }
            else
            {
                GamaRate += "0";
                EpsilonRate += "1";
            }

            OneCount = 0;
            ZeroCount = 0;
        }

        static void ToDecimal()
        {
            GamaRateBin = Convert.ToInt32(GamaRate, 2);
            EpsilonRatebin = Convert.ToInt32(EpsilonRate, 2);
        }
    
        static void FindOxygenRate()
        {
            int x = Input.Length;
            //OxgenHolder = Input;

            for (int i = 0; i < 11; i++)
            {
                for (int y = 0; y < x; y++)
                {
                    if (Input[y].Substring(i,1) == "0" && GamaRate[i] == '0')
                    {
                        OxgenHolder.Add(Input[y]);
                    }
                    else if (Input[y].Substring(i) == "1" && GamaRate[i] == '1')
                    {
                        OxgenHolder.Add(Input[y]);
                    }
                }
            }
        }
    
    }

}