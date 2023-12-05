using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetNarratif.Rooms
{
    internal class PremierEtage : Room
    {
        internal override string CreateDescription() =>
@"Vous vous retrouver devant un couloir sombre.
Les lumieres clignotante.
Plusieurs portes sont fermer, mais au bout du couloir semble avoir une [piece] avec une
petite lumière.
Vous pouvez aussi retourner en [bas].
";        
        
        

        internal override void ReceiveChoice(string choice)
        {
            switch (choice)
            {
                case "piece":
                    Console.WriteLine("Vous approchez de la piece sans faire de bruit..." +
                        " vous trouver ce qui semble entre un gardien de sécurité couché au sol... ");
                        
                    Game.Transition<PieceEtage>();
                    break;                

                case "bas":
                    Console.WriteLine("Vous retournez en bas");
                        Game.Transition<PremierePiece>();
                    break;

                default:
                    Console.WriteLine("Commande invalid.");
                    break;
            }
        }
    }
}
