﻿using System;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
namespace Day03
{
    internal class Program
    {

        static List<HouseCordinate> houses = new List<HouseCordinate>(); // to list all houses.

        static void Main(string[] args)
        {
            string filename = "Input Day03-1";
            int onevisithouse = 0;
            HouseCordinate CurrentLocation = new HouseCordinate(){X=0,Y=0,Count=1}; // "^ & V" change Y, "< & >" change X.to track current location
            
            houses.Add(new HouseCordinate(){X=0,Y=0,Count=1,ID="00"} ); // Added Starting location. santa always start from here.
            
            char[] c = File.ReadAllText(filename).ToCharArray(); // 8192 is lenght. get moves in char array

            for (int i = 0; i < c.Length; i++)
            {
                switch (c[i])
                {
                    case '^': // y ++
                        CurrentLocation.Y +=1;
                        CurrentLocation.updateID();
                        Housemaker(CurrentLocation);
                    break;
                    case 'v':
                        CurrentLocation.Y +=-1;
                        CurrentLocation.updateID();
                        Housemaker(CurrentLocation);
                    break;
                    case '>':
                        CurrentLocation.X +=1;
                        CurrentLocation.updateID();
                        Housemaker(CurrentLocation);
                    break;
                    case '<':
                        CurrentLocation.X +=-1;
                        CurrentLocation.updateID();
                        Housemaker(CurrentLocation);
                    break;
                    
                }
                
            }
            System.Console.WriteLine(houses.Count); // okay the answear for part one is 2592. the count of all unique houses not houses with one present 
                                                    // it's late i do this at end of the day :) basicly i fount the answear days ago but i think it need house with one visit.

            foreach (HouseCordinate item in houses)
            {
                if (item.Count == 1)
                {
                    onevisithouse++;
                }
            }

            System.Console.WriteLine("house with only one visit : {0}",onevisithouse);

        }// end of main

        // create new house cordinate and id and make sure only one house with unique cordinate exist.
        static void Housemaker(HouseCordinate house)
        {
            if (IdSearch(house.ID))
            {
                houses.Where(x => x.ID == house.ID).ToList().ForEach(b => b.Count++);
            }
            else
            {
                houses.Add(new HouseCordinate(){X= house.X,Y=house.Y,Count=1,ID = house.ID});
            }

        
        }

        static bool IdSearch(string id)
        {
            foreach (HouseCordinate item in houses)
            {
                if (item.ID == id)
                {
                    return true;
                }
            }
            return false;
        }
    }


    class HouseCordinate
    {
        public int X;
        public int Y;
        public int Count;

        public string ID="";

        public void updateID()
        {
           ID = X.ToString()+Y.ToString();
        }
    }
}




