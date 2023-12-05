using ProjetNarratif.Rooms;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

namespace ProjetNarratif
{
    internal class Game
    {
        List<Room> rooms = new();
        Room currentRoom;
        internal bool IsGameOver() => isFinished;
        static bool isFinished;
        static string nextRoom = "";
        internal static bool dote;
        internal static bool anti;
        internal static bool antidote;
        internal static int hp = 5;
        internal static Stopwatch stopwatch = new Stopwatch();
        internal static Stopwatch alarmStopwatch = new Stopwatch();

        internal static void LoseHP()
        {
            hp--;
            if (hp <= 0)
            {
                Console.WriteLine("You died");
                Game.Finish();
            }
            else
            {
                Console.WriteLine($"Tu prend des dégats. Pv restant = {hp}/ 5");
            }
        }

        internal void Add(Room room)
        {
            rooms.Add(room);
            if (currentRoom == null)
            {
                currentRoom = room;
            }
        }

        internal string CurrentRoomDescription => currentRoom.CreateDescription();

        internal void ReceiveChoice(string choice)
        {
            currentRoom.ReceiveChoice(choice);
            CheckTransition();
        }

        internal static void Transition<T>() where T : Room
        {
            nextRoom = typeof(T).Name;
        }

        internal static void Finish()
        {
            isFinished = true;
        }

        internal static void Finish1()
        {
            isFinished = true;
            Console.WriteLine(@"Vous n'avez pas reussi a desamorcer l'alarme a temps.
Les autorie ont ete aviser.");
        }

        internal void CheckTransition()
        {
            foreach (var room in rooms)
            {
                if (room.GetType().Name == nextRoom)
                {
                    nextRoom = "";
                    currentRoom = room;
                    break;
                }
            }
        }
    }
}
