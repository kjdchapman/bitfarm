using System;
using System.Collections.Generic;
using System.Linq;
using BitFarm.Domain.Interfaces;
using BitFarm.Domain.Stages;
using BitFarm.Tests;

namespace BitFarm.Domain
{
    public class Game
    {
        private List<IPlayer> _players = new List<IPlayer>();
        private Round _currentRound;
        private IRoundsFactory _roundsFactory;
        private IEnumerable<Round> _rounds;

        public Game(IRoundsFactory roundsFactory)
        {
            _roundsFactory = roundsFactory;
        }

        public Game() : this(new DefaultRoundsFactory()) { }

        public void Start()
        {
            if (_players.Count == 0) throw new InvalidOperationException("Cannot start a game without players.");

            SetupStagesAndRounds();
            StartGameLoop();
        }

        private void StartGameLoop()
        {
            PublishAvailableMoves();
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
            _currentRound = _rounds.First();
        }

        private void PublishAvailableMoves()
        {
            // var availableMoves = GetDefaultMoves();
            // availableMoves.AddAll(_round.Select...)

            var availableMoves = _rounds.Select(r => r.AvailableMove).ToList();

            foreach (var player in Players)
            {
                player.UpdatePossibleMoves(availableMoves);
            }
        }
    }
}