using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetNarratif.Rooms
{
    internal class Porte : Room
    {
        internal static bool isKeyCollected;
        internal static int rep = 0;
        internal override string CreateDescription() =>
@"Au moment ou vous entrer a l'interieur la porte se referme derriere vous et un scientifique sors de derriere son bureau.
Il vous dit :
Vous êtes maintenant coincier ici. Je vais vous donner une devinette et si seulement si vous trouver la bonne réponse je vous laisse soritr.
Qu'est ce qui reflechit sans reflechir?
";

        internal override void ReceiveChoice(string choice)
        {
            switch (choice)
            {
                case "miroir":
                    Console.WriteLine("Bonne reponse, je vous laisse sortir.");                   
                    Game.Transition<PremierePiece>();
                    break; 
                    
                default:
                    if (rep == 0)
                    {
                        Console.WriteLine("Mauvaise reponse, voici un indice : C'est un object");
                        rep++;
                    }
                    else if (rep == 1)
                    {
                        Console.WriteLine("Mauvaise reponse, voici un indice : C'est tres fragile");
                        rep++;
                    }
                    else if (rep == 2)
                    {
                        Console.WriteLine("Mauvaise reponse, voici un indice : Vous pouvez vous voir en regardant dedans"); 
                        rep++;
                    }
                    else
                    {
                        Console.WriteLine("Vous n'avez pas trouver la reponse. Vous serez enfermer ici a jamais.");
                        Game.Finish();
                    }

                    
                    break;
            }
        }
    }
}
