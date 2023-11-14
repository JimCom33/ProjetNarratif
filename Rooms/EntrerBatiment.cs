using ProjetNarratif;

namespace ProjetNarratif.Rooms
{
    internal class EntrerBatiment : Room
    {
        internal static bool mirorIsCovered;

        

        internal override string CreateDescription()
        {
            Game.alarmStopwatch.Start();
            return
                @"Une alarme se met à sonner. Vous avez une minute pour la désactiver avant que la police sois avisé.
Vous devez vite trouver le code pour la désactiver.
Un [babillard] se trouve au fond de la pièce.
Un [telephone] est sur le bureau d'entrer.
Vous pouvez tenter le code.
";
        }

        

        internal override void ReceiveChoice(string choice)
        {
            if(Game.alarmStopwatch.Elapsed.TotalMinutes > 1)
            {
                Game.Finish();
                return;
            }
            switch (choice)
            {
                case "babillard":
                    Console.WriteLine("Vous courez au babillard. Il y a que des contract de confidentialité. Vous revenez donc à l'alarme.");
                    mirorIsCovered = true;
                    break;
                case "telephone":
                    Console.WriteLine("Vous prenez le telephone. En dessous se trouve une note avec écrit : 4189280181");
                    break;
                case "4189280181":
                    Console.WriteLine("Vous avez réussi à arreter l'alarme. Puisque la porte s'est refermer et qu'il est impossible de l'ouvrir, vous vous " +
                        "dirigez vers l'exterieur de la piece.");
                    Game.Transition<PremierePiece>();
                    break;
                default:
                    Console.WriteLine("Commande invalide.");
                    break;
            }
        }
    }
}
