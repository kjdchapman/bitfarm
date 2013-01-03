using System;
using System.Collections.Generic;
using BitFarm.Domain.Interfaces;

namespace BitFarm.Domain
{
    public class Game
    {
        private List<IPlayer> _players = new List<IPlayer>();
        
        public void Start()
        {
            if (_players.Count == 0) throw new InvalidOperationException("Cannot start a game without players.");
        }

        public void Enrol(IPlayer player)
        {
            if (this._players.Count >= 5) throw new InvalidOperationException("Maximum number of players in a game is five.");
            this._players.Add(player);

            player.Enrol(this);
        }

        public IEnumerable<IPlayer> Players
        {
            get { return _players; }
        }
    }
}