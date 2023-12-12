using ProjetNarratif;
using ProjetNarratif.Rooms;

var game = new Game();
game.Add(new DevantBatiment());
game.Add(new EntrerBatiment());
game.Add(new PremierePiece());
game.Add(new PremierEtage());
game.Add(new Ascenseur());
game.Add(new SousSol());
game.Add(new PieceEtage());
game.Add(new PieceSousSol());
game.Add(new _100());
game.Add(new cahier());
game.Add(new distributeur());
game.Add(new balance());
game.Add(new Porte());
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