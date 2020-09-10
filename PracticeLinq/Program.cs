using System;
using System.Collections.Generic;
using System.Linq;

namespace PracticeLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> videogames = new List<string>();
            videogames.Add("Railroad Tycoon 3");
            videogames.Add("GearCity");
            videogames.Add("Europa Universalis IV");
            videogames.Add("BeamNG Drive");
            videogames.Add("Floating Simulator");


            var gamesordered = videogames.OrderBy(game =>  game.Length);
            Console.ReadLine();
          

        }
    }
}
