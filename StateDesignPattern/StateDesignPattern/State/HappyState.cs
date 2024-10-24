using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDesignPattern.State
{
    public class HappyState : IPlaylistState
    {
        public void Play(PlaylistPlayer player)
        {
            Console.WriteLine("Playing feel good songs!");
        }
        public void Skip(PlaylistPlayer player)
        {
            Console.WriteLine("Didn't like the song? Skipping... moving to the next happy song.");
        }
        public void Pause(PlaylistPlayer player)
        {
            Console.WriteLine("Pausing the playlist!");
            player.SetState(new EnergeticState());
        }
    }
}
