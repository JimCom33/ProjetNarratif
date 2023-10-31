using ProjetNarratif;
using ProjetNarratif.Rooms;

var game = new Game();
game.Add(new DevantBatiment());
game.Add(new EntrerBatiment());
game.Add(new PremierePiece());
game.Add(new LivingRoom());

while (!game.IsGameOver())
{
    Console.WriteLine("--");
    Console.WriteLine(game.CurrentRoomDescription);
    string? choice = Console.ReadLine()?.ToLower() ?? "";
    Console.Clear();
    game.ReceiveChoice(choice);
}

Console.WriteLine("FIN");
Console.ReadLine();