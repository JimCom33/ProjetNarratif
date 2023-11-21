using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetNarratif.Rooms
{
    internal class SousSol : Room
    {
        internal override string CreateDescription() => @"Arrivé au sous-sol tout est illuminé. Le couloir est super long.
Des deux côté du couloir il y a des pièce avec des grosse vitre pour que l'on puisse voir à l'interieur.
Les pièces ressemble a des chambres.
Pour l'instant tout les chambres sont vides.
Mais plus vous avancez dans le couloir vous entendez des bruits.
Rendu a moins de la moitier du couloir. Vous voyez dans une des chambres un espèce de chien qui a l'air très affamé.
Vous pouvez appercevoir au loin une [porte].
Aucune idée elle sert à quoi.
Vous pouvez faire demi tour et retourner dans l'[ascenseur]."
;




        internal override void ReceiveChoice(string choice)
        {
            switch (choice)
            {
                case "porte":
                    Console.WriteLine(@"Vous courez a tout vitesse vers la porte en espérant que ce soit la porte de sortie.
Sur votre chemin les chambres sont de plus en plus occupée par différents animaux étranges.
De plus en plus affamé.
 Vous arrivez presque à la porte mais les animaux commence a se transformer en humain.
Des humains transformer. Qui semblent être génétiquement modifier.
Très dangereux. Tous essayant de sortir de leurs chambres respective en frappant dans la vitre
Vous arrivez à la porte. Elle est complètement barré. Vous devez donc refaire tout le couloir et retourner dans l'ascenseur.");
                    Game.Transition<Ascenseur>();                                                    
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
