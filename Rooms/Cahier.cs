using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetNarratif.Rooms
{
    internal class cahier : Room
    {
        internal override string CreateDescription() => @"Dans le cahier il y a a la premiere page
l'antidote pour le serum [foudroitus]
A la deuxieme page il y a l'antidote pour le serum [garious]
A la troisieme page il y a l'antidote pour le serum [tempiode]";


        internal override void ReceiveChoice(string choice)
        {
            switch (choice)
            {
                case "foudroitus":

                    Console.WriteLine("Il n'y aucun indice");                   
                    break;

                case "garious":
                    Console.WriteLine("Il n'y aucun indice");
                    break;

                case "tempiode":
                    Console.WriteLine(@"(La) combi(Na)ison est i(C)i 
1- acide acetique
2- cyanure
3- chlorure d'hydrogène");
                    Game.Transition<_100>();
                    break;

                default:
                    Console.WriteLine("Commande invalide.");
                    break;
            }
        }

    }
}
