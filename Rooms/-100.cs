using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetNarratif.Rooms
{
    internal class _100 : Room
    {

        

        internal override string CreateDescription() => @"A votre arriver vous voyez un laboratoire.
Il y a un [cahier] avec un tableau periodique au dessu.
Il y a un [distributeur] automatique avec plusieurs flasque contenant un liquide a l'intérieur
tous relier a un certain nombre.
Il y a une [balance] avec de acide acetique, cyanure et de la chlorure d'hydrogène.
Et un [contenant] vide.
Vous pouvez retourner dans l'[ascenseur]";


            internal override void ReceiveChoice(string choice)
            {
                switch (choice)
                {
                    case "cahier":                        
                        Game.Transition<cahier>();
                        break;

                    case "distributeur":
                        Game.Transition<distributeur>();
                    
                        break;

                    case "contenant":
                    if (Game.anti && Game.dote)
                    {
                        Console.WriteLine("Vous mixer les deux substance et vous obtenez ANTIDOTE");
                        Game.antidote = true;
                    }
                    else
                    {
                        Console.WriteLine("Vous n'avez rien a faire ici pour le moment.");
                    }
                        
                        break;

                    case "balance":
                    Game.Transition<balance>();
                        break;

                    case "ascenseur":
                        Game.Transition<Ascenseur>();
                    break;


                    default:
                        Console.WriteLine("Commande invalide.");
                        break;
                }
            }
        
    }
}
