using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetNarratif.Rooms
{
    internal class balance : Room
    {

        

        internal override string CreateDescription() => @"Vous pouvez peser les substance. 
[acide acetique]
[cyanure]
[chlorure d'hydrogène]
Vous pouvez revenir au milieu de la [piece]";


        internal override void ReceiveChoice(string choice)
        {
            switch (choice)
            {
                case "acide acetique":
                    Console.WriteLine("6g");
                    break;

                case "cyanure":
                    Console.WriteLine("1g");

                    break;

                case "chlorure d'hydrogène":
                    Console.WriteLine("9g");
                    break;

                case "piece":
                    Game.Transition<_100>();
                    break;


                default:
                    Console.WriteLine("Commande invalide.");
                    break;
            }
        }

    }
}
