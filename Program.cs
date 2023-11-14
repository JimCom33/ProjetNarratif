using ProjetNarratif;
using ProjetNarratif.Rooms;

var game = new Game();
game.Add(new DevantBatiment());
game.Add(new EntrerBatiment());
game.Add(new PremierePiece());
game.Add(new PremierEtage());

Game.stopwatch.Start();

while (!game.IsGameOver())
{
    Console.WriteLine("--");
    Console.WriteLine(game.CurrentRoomDescription);
    string? choice = Console.ReadLine()?.ToLower() ?? "";
    Console.Clear();
    game.ReceiveChoice(choice);
    
}


double totalMinutes = Game.stopwatch.Elapsed.Minutes;
Console.WriteLine($"FIN {totalMinutes} m");
Console.ReadLine();