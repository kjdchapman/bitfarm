using System;
using System.Collections.Generic;
using BitFarm.Tests;

namespace BitFarm.Domain
{
    public class Game
    {
        private List<Player> _players = new List<Player>();

        public void Start()
        {
            if (_players.Count == 0) throw new InvalidOperationException("Cannot start a game without players.");
            
            PublishAvailableMoves();
        }

        private void PublishAvailableMoves()
        {
            var defaultAvailableMoves = new List<Move> {new TakeOneGrain()};
            foreach (var player in Players)
            {
                player.PublishAvailableMoves(defaultAvailableMoves);
            }
        }

        public void Enrol(Player player)
        {
            if (this._players.Count >= 5) throw new InvalidOperationException("Maximum number of players in a game is five.");
            this._players.Add(player);

            player.Enrol(this);
        }

        public IEnumerable<Player> Players
        {
            get { return _players; }
        }
    }
}