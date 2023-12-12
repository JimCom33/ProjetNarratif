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
                    Game.Transition<PremierEtage>();
                    break;
                case "ascenseur":
                    Console.WriteLine("Vous rentez dans l'ascenseur.");   
                    Game.Transition<Ascenseur>();
                    break;
                case "porte":
                    Console.WriteLine("Vous entrez dans la piece");
                    Game.Transition<Porte>();
                    break;

                default:
                    Console.WriteLine("Commande invalide.");
                    break;
            }
        }
    }
}
