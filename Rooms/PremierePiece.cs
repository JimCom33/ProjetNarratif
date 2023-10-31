namespace ProjetNarratif.Rooms
{
    internal class PremierePiece : Room
    {
        internal static bool isKeyCollected;

        internal override string CreateDescription() =>
@"Vous arrivez au bout du couloir.
À votre gauche il y a des [escaliers].
À votre droite il y a un [ascenseur] et une autre [porte] fermé.
";

        internal override void ReceiveChoice(string choice)
        {
            switch (choice)
            {
                case "escaliers":
                    Console.WriteLine("Vous décidez de prendre les escaliers qui vous mène à l'étage du haut.");
                    Game.Transition<LivingRoom>();
                    break;
                case "ascenceur":
                    
                    break;
                case "porte":

                    break;

                default:
                    Console.WriteLine("Commande invalide.");
                    break;
            }
        }
    }
}
