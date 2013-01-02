using System.Collections.Generic;
using BitFarm.Domain.Interfaces;

namespace BitFarm.Domain
{
    public class Player : IPlayer
    {
        private Game _enrolledGame;
        private List<Move> _possibleMoves;

        public Player()
        {
            _possibleMoves = new List<Move>();
        }

        public IEnumerable<Move> GetPossibleMoves
        {
            get { return _possibleMoves; }
        }

        public void Enrol(Game game)
        {
            _enrolledGame = game;
        }

        public void UpdatePossibleMoves(List<Move> availableMoves)
        {
            _possibleMoves = availableMoves;
        }
    }
}