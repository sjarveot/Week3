using System;

namespace Personality_Test_switch
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm palub kasutajal sisestada enda lemmikvärv;
            //kui kasutaja sisestab "punane",konsool kuvab "oled romantiline";
            //kui kasutaja sisestab "sinine", konsool kuvab "oled töökas";
            //kui kasutaja sisestab "roheline", konsool kuvab "oled loduse sõber";
            //kui kasutaja sisestab midagi muud , konsool kuvab "oled {userColor} ükssarvik";

            Console.WriteLine("Sisesta enda lemmikvärv:");
            string userColor = Console.ReadLine().ToLower();

            switch (userColor)
            {
                case "punane":
                    Console.WriteLine("Oled romantiline");
                    break;
                case "sinine":
                    Console.WriteLine("Oled  töökas.");
                    break;
                case "roheline":
                    Console.WriteLine("Oled looduse sõber");
                    break;
                default:
                    Console.WriteLine($"Oled {userColor} ükssarvik.");
                    break;
            }

            Console.WriteLine("Kena päeva!");
        }
    }
}
