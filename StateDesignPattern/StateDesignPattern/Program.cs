using System.Numerics;
using System.Security.Cryptography.X509Certificates;

namespace StateDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PlaylistPlayer player = InitializePlayerMood();

            while (true)
            {
                Console.WriteLine("\nWhat would you like to do?");
                Console.WriteLine("1. Play Song\n" +
                    "2. Pause Song and Skip Playlist\n" +//it changes the state
                    "3. Skip Song\n" +
                    "4. Exit");

                int userAction = Convert.ToInt32(Console.ReadLine());
                UserActionChoice(userAction, player);
            }
        }
        public static PlaylistPlayer InitializePlayerMood()
        {
            Console.WriteLine("How are you feeling?");//asking user about their current state
            Console.WriteLine("1. Sad\n" +
                "2. Relaxed\n" +
                "3. Happy\n" +
                "4. Energetic");

            int moodChoice = Convert.ToInt32(Console.ReadLine());
            IPlaylistState initialState = StateSelect.GetState(moodChoice);

            return new PlaylistPlayer(initialState);
        }
        public static void UserActionChoice(int userAction, PlaylistPlayer player)
        {
            switch (userAction)//actions based on which state will be changed
            {
                case 1:
                    player.PlaySong();
                    break;
                case 2:
                    player.Pause();//changing state; this will trigger the state design pattern principle where the current running state(say sad mood) will be stopped and newly state(according to program, say relaxed mood) will be brought up affecting to object by this internal action(pause)
                    break;
                case 3:
                    player.SkipSong();
                    break;
                case 4:
                    Console.WriteLine("Exiting the playlist...");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please enter 1, 2, 3, or 4.");
                    break;
            }
        }
    }
}
