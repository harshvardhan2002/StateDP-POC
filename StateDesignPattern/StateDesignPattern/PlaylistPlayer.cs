using StateDesignPattern.State;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDesignPattern
{
    public class PlaylistPlayer
    {
        private IPlaylistState _currentState;
        public PlaylistPlayer(IPlaylistState initialState)
        {
            _currentState = initialState;
        }
        public void SetState(IPlaylistState newState)
        {
            _currentState = newState;
        }
        public void PlaySong()
        {
            _currentState.Play(this);
        }
        public void SkipSong()
        {
            _currentState.Skip(this);
        }
        public void Pause()
        {
            _currentState.Pause(this);
        }
    }
}
