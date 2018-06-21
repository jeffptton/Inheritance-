using System;
using System.Collections.Generic;
using System.Text;

namespace final15
{
    class Story
    {
        static void Main(string[] args)
        {
            Console.WriteLine("As an archeologist, she travels all over the world looking for historic  mystical artifacts before they fall into the wrong hands! ");
            Console.ReadKey();

            Console.WriteLine("Her reputation grants the nickname The Tomb Raider");
            Console.ReadKey();

            Console.WriteLine(" Her archaeological discoveries are extensive, including the Ark of the Covenant, the Scion , Excalibur, and the Dagger of Xian. ");
            Console.ReadKey();


            Console.WriteLine("There goes Laura Croft off to save the day ");
            Console.ReadKey();

            TombRaider LadyCroft = new TombRaider("Laura", "WetSuite", 100, "Eagle Eye");

            // Get
            int Health = LadyCroft._power;

            // Set
            LadyCroft._power = 100;

            Console.WriteLine(".......................To be continued");
            Console.ReadKey();












        }


    }
    }
      
    