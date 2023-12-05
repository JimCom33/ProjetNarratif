using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetNarratif.Rooms
{
    
    
    internal class distributeur : Room
    {
        

        internal override string CreateDescription() => @"Vous pouvez entrer des nombres : 
Vous pouvez revenir au milieu de la [piece]";


        internal override void ReceiveChoice(string choice)
        {
            switch (choice)
            {
                case "57116":
                    Console.WriteLine("Vous obtenez ANTI");
                    Game.anti = true;
                    
                    break;

                case "619":
                    Console.WriteLine("Vous obtenez DOTE");
                    Game.dote = true;
                    
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
