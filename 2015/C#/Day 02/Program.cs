using System;
using System.Runtime.CompilerServices;

namespace Day02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            List<Box> boxes = new List<Box>();
            string FilePath = "Input Day02-1.txt";
            int i = 0;
            //int totalpaper = 0;
            int totalpaperextra = 0;
            int TotalRibbon = 0;

            foreach (string item in File.ReadLines(FilePath))
            {

                Box box = new Box(item);

                boxes.Add(box);
                totalpaperextra += boxes[i].totalArea;
                TotalRibbon += boxes[i].RibbonNeed;

                i++;
                
            }

            Console.WriteLine("\nTotal paper wrap with extra need is : {0}\n",totalpaperextra); // Part one Answear is "1588178"
            Console.WriteLine("\nTotal Ribbon need is : {0}",TotalRibbon); // Part two Answear is "3783758"

        }

        internal class Box
        {
            public int Lenght;
            public int width;
            public int height;
            public int area;
            public int Smallest;
            public int totalArea;
            public int RibbonNeed;

            public Box(string s)
            {
                string[] strings = s.Split('x');
                Lenght = int.Parse(strings[0]);
                width = int.Parse(strings[1]);
                height = int.Parse(strings[2]);
                area = AreaCalculate();
                Smallest = SmallestFind();
                RibbonNeed = RibonNeed();
                totalArea = area + Smallest;
            }

            private int AreaCalculate()
            {
                // formula 2*l*w + 2*w*h + 2*h*l
                return 2*Lenght*width + 2*width*height + 2*height*Lenght;
            }

            private int SmallestFind()
            {
                int[] sm = { Lenght*width , width*height , height*Lenght };

                return sm.Min();
            }

            private int RibonNeed()
            {
                int[] sm = {Lenght,width,height};
                Array.Sort(sm);

                return (Lenght*width*height)+(sm[0]+sm[1]+sm[0]+sm[1]);
            }
        }
    
    }
}
