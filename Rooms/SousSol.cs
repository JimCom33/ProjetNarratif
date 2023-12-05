using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetNarratif.Rooms
{
    internal class SousSol : Room
    {
        internal override string CreateDescription() => @"Arrivé au sous-sol tout est illuminé. Le couloir est long.
Sur la gauche du couloir il y a des pièce avec des grosse vitre pour que l'on puisse voir à l'interieur.
Les pièces ressemble a des chambres.
Pour l'instant tout les chambres sont vides.
La premiere piece est illuminer.
Elles sont tous noir jusqu'a la sixieme qui est illuminer.
Ensuite, tous fermer jusqu'a la dixieme qui elle est illuminer.
Apres la dixieme elles sont noir jusqu'a la dixseptieme.
Finalement elles sont tous noir sauf la vingtieme.
Vous arrivez a la porte.
Elle a un code a 4 chiffres.
Vous pouvez le tentez.
Vous pouvez faire demi tour et retourner dans l'[ascenseur]."
;




        internal override void ReceiveChoice(string choice)
        {
            switch (choice)
            {
                case "4362":
                    Console.WriteLine(@"Vous avez entrer le bon code.");
                    Game.Transition<PieceSousSol>();                                                    
                    break;


                case "ascenseur":
                    Console.WriteLine("Vous courez vers l'ascenseur");
                    Game.Transition<Ascenseur>();
                    break;

                default:
                    Console.WriteLine("Commande invalide.");
                    break;
            }
        }
    }
}
