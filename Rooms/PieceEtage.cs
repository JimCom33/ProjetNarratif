using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetNarratif.Rooms
{
    internal class PieceEtage : Room
    {
        internal override string CreateDescription() =>
@"La panique commence a s'emparer de vous. 
Vous ne savez plus quoi faire.
Vous pouvez aller voir le [garde].
Tentez de sortir par la [fenetre] et fuir.
Ou retourner en [bas].
";
           
 
        

        internal override void ReceiveChoice(string choice)
        {
            switch (choice)
            {
                case "garde":
                    Console.WriteLine(@"Rien de spécial sur le garde... seulement sa tête qui a été complètement manger par quelque chose ou quelqu'un...?");
                    break;

                case "fenetre":
                    Console.WriteLine("Vous tentez de sortir par la fenêtre mais elle est completement bloqué.");
                    break;

                case "bas":
                    Console.WriteLine("Vous sortez de la piece en courrant et retournez en bas.");
                    Game.Transition<PremierePiece>();
                    break;

                default:
                    Console.WriteLine("Commande invalide");
                    break;
                    
            }
        }
    }
}
