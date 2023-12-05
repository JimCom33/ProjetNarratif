using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetNarratif.Rooms
{
    internal class PieceEtage : Room
    {
        internal static bool antidote;

        internal override string CreateDescription() =>
@"Vous etes intriguez.
Vous pouvez aller voir le [garde].
Tentez de sortir par la [fenetre] et fuir.
Ou retourner en [bas].
";
           
 
        

        internal override void ReceiveChoice(string choice)
        {
            switch (choice)
            {
                case "garde":

                    if (antidote)
                    {
                        if (Game.stopwatch.Elapsed.TotalMinutes > 20)
                        {
                            Console.WriteLine(@"Vous n'avez pas eu le temps de sauver le garde il est donc mort...
et vous le serez probablement bientot.");
                            Game.Finish();
                        }
                        else
                        {
                            Console.WriteLine(@" Vous donnez l'antidote au garde. Il se sent beaucoup mieux et vous aide a soritr de ce malheur.
Vous etes maintenant de retour dans votre appartement et vous n'avez pas les mots
pour decire ce qui vien de se passer.");
                            Game.Finish();
                        }
                        
                    }
                    else
                    {
                        Game.stopwatch.Start();
                        Console.WriteLine(@"Le garde est encore en vie. Il vous dit : 
aider moi svp... je vais bientot mourir. J'ai ete empoisonné par le savant fou.
Vous devez a tout pris trouver avec quoi il ma empoisonné et concocter l'antidote.
Je suis le seul a avoir le code pour sortir de ce batiment.
Si vous ne me sauvez pas la vie... vous y serez pris a tout jamais.
Depechez vous. Il me reste moins de 20 minutes avant de mourir.");
                    }
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
