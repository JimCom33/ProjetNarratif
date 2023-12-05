using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetNarratif.Rooms
{
    internal class PieceSousSol : Room
    {
        
        
            internal override string CreateDescription() =>
    @"Vous entrer dans la piece.
Ca semble etre un bureau.
Il y a un cahier de note sur le bureau qui semble appartenir au savant fou.
La premiere page parle d'un serum qui rend les humains completement fou appeler foudroitus.
Le savant dit qu'il a deja essayer ce serum.
La deuxieme page parle d'un serum qui rend les humains en loups garou appeler garious.
Ĉe serum a aussi ete essayer.
La troisieme page parle d'un serum qui tue les humains apres un certain nombre de temps appeler tempiode
Il n'y a rien d'autre d'interessant dans le bureau.
Vous pouvez retourner dans l'[ascenseur].";



            internal override void ReceiveChoice(string choice)
            {
                switch (choice)
                {
                    case "ascenseur":
                        
                        Game.Transition<Ascenseur>();
                        break;
                  
                    default:
                        Console.WriteLine("Commande invalid.");
                        break;
                }
            }
        
    }
}
