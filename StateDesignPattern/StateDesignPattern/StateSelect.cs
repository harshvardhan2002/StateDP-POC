using StateDesignPattern.State;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDesignPattern
{
    internal class StateSelect//created new class for initial state(mood) selection so that OCP isnt violated!
    {
        public static IPlaylistState GetState(int moodChoice)
        {
            switch (moodChoice)
            {
                case 1: return new SadState();
                case 2: return new RelaxedState();
                case 3: return new HappyState();
                case 4: return new EnergeticState();
                default: return new SadState();
            }
        }
    }
}
