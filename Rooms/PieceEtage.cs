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
                    break;

                case "fenetre":
                    break;

                case "bas":
                    break;

                default:
                    Console.WriteLine("Commande invalide");
                    break;
                    
            }
        }
    }
}
