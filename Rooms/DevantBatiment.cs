namespace ProjetNarratif.Rooms
{
    internal class DevantBatiment : Room
    {
        internal override string CreateDescription() =>
@"Tu es dans ton appartement avec ton cousin.
Depuis quelque année il y a un batiment très suspect de l'autre côté de la rue.
Il est tard et vous n'avez rien à faire... 
vous décidé d'aller voir le batiment
La [porte] d'entrer du bâtiment est mal fermé... il est donc possible d'y entrer.
Vous pouvez faire le [tour] du bâtiment pour essayer de voir 
si vous ne voyez pas quelque chose ou quelqu'un à l'interieur
";

        internal override void  ReceiveChoice(string choice)
        {
            switch (choice)
            {
                case "porte":
                    Console.WriteLine("Vous entrez dans le bâtiment et la porte se referme derrière vous.");
                    Game.Transition<EntrerBatiment>();
                    break;
                case "tour":
                    Console.WriteLine("Vous faites le tour du bâtiment et tout les fenêtres sont bloqué par quelque chose...");
                    break;
                    
                default:
                    Console.WriteLine("Commande invalide.");
                    break;
            }
        }
    }
}
