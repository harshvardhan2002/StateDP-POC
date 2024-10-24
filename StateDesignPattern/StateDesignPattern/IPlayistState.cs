using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDesignPattern
{
    public interface IPlaylistState//defines actions that each state must have or implement
    {
        void Play(PlaylistPlayer player);
        void Skip(PlaylistPlayer player);
        void Pause(PlaylistPlayer player);
    }
}