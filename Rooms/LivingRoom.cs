using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetNarratif.Rooms
{
    internal class LivingRoom : Room
    {
        internal override string CreateDescription() =>
@"Dans le salon, le [sofa] semble être confortable.
La [tv] illumine faiblement la salle.
Tu peux revenir dans ta [chambre].
";        
        
        

        internal override void ReceiveChoice(string choice)
        {
            switch (choice)
            {
                case "sofa":
                    Console.WriteLine("Tu t'assie sur le sofa et tu est captiver par la lumière clignotante de la tv");
                    break;

                case "tv" :
                    Console.WriteLine("Tu touche la tv et tu est aspirer dans un monde parallèle");
                    Game.Finish();
                    break;

                case "chambre":
                    Console.WriteLine("Tu retourne dans ta chambre");
                        Game.Transition<DevantBatiment>();
                    break;

                default:
                    Console.WriteLine("Commande invalid.");
                    break;
            }
        }
    }
}
