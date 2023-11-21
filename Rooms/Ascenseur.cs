using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetNarratif.Rooms
{
    internal class Ascenseur : Room
    {
        internal override string CreateDescription() => @"l'ascenseur est tout sauf normal.
Les seuls options sont le sous-sol [ss] ou [-100]
Vous pouvez aussi [sortir] de l'ascenceur";


        internal override void ReceiveChoice(string choice)
        {
            switch (choice)
            {
                case "ss":

                    Console.WriteLine("Vous descendez dans le sous-sol.");
                    Game.Transition<SousSol>();
                    break;

                case "-100":
                    Console.WriteLine("Vous descendez à l'étage -100. Ce qui semble prendre une éternité");
                    break;

                case "sortir":
                    Console.WriteLine("Vous sortez de l'ascenseur");
                    Game.Transition<PremierePiece>();
                    break;
            }
        }
    }
}
