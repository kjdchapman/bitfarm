using System;
using System.Collections.Generic;
using System.Linq;
using BitFarm.Domain.Stages;
using BitFarm.Tests;

namespace BitFarm.Domain
{
    public class Game
    {
        private List<Player> _players = new List<Player>();
        private Round _currentRound;
        private IRoundsFactory _roundsFactory;
        private IEnumerable<Round> _rounds;

        public Game()
        {
            _roundsFactory = new DefaultRoundsFactory();
        }

        public void Start()
        {
            if (_players.Count == 0) throw new InvalidOperationException("Cannot start a game without players.");

            SetupStagesAndRounds();
            PublishAvailableMoves();
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

        public Round CurrentRound
        {
            get { return _currentRound; }
        }

        public Stage CurrentStage
        {
            get { return _currentRound.Stage; }
        }

        private void SetupStagesAndRounds()
        {
            _rounds = _roundsFactory.GetRounds();
            _currentRound = _rounds.Single(r => r.Number == 1);
        }

        private void PublishAvailableMoves()
        {
            var defaultAvailableMoves = new List<Move> {new TakeOneGrain()};
            foreach (var player in Players)
            {
                player.PublishAvailableMoves(defaultAvailableMoves);
            }
        }
    }
}