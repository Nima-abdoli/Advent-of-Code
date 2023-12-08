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
            int totalpaper = 0;
            int totalpaperextra = 0;

            foreach (string item in File.ReadLines(FilePath))
            {

                Box box = new Box(item);

                boxes.Add(box);
                totalpaperextra += boxes[i].totalArea;
                totalpaper += boxes[i].area;

                //System.Console.WriteLine("{0} - Firstbox total area is : {1} and total need is : {2} ",i,boxes[i].totalArea,totalpaperextra);
                i++;
                

            }

            System.Console.WriteLine("-----------------------------------------------------\nTotal paper wrap need is : {0}",totalpaper);
            System.Console.WriteLine("\nTotal paper wrap with extra need is : {0}\n",totalpaperextra); // Part one Answear is "1588178"
            

        }

        internal class Box
        {
            public int Lenght;
            public int width;
            public int height;
            public int area;
            public int Smallest;
            public int totalArea;

            public Box(string s)
            {
                string[] strings = s.Split('x');
                Lenght = int.Parse(strings[0]);
                width = int.Parse(strings[1]);
                height = int.Parse(strings[2]);
                area = AreaCalculate();
                Smallest = SmallestFind();
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
        }
    
    }
}
