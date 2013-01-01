using System;
using System.Collections.Generic;

namespace BitFarm.Tests
{
    public class AgricolaGame
    {
        private List<AgricolaPlayer> _players = new List<AgricolaPlayer>();

        public void Start()
        {
            if (_players.Count == 0) throw new InvalidOperationException("Cannot start a game without players.");
        }

        public void Enrol(AgricolaPlayer player)
        {
            if (this._players.Count >= 5) throw new InvalidOperationException("Maximum number of players in a game is five.");
            this._players.Add(player);
        }

        public IEnumerable<AgricolaPlayer> Players
        {
            get { return _players; }
        }
    }
}