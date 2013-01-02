using System.Collections.Generic;

namespace BitFarm.Domain
{
    public class Player
    {
        private Game _enrolledGame;
        private List<Move> _possibleMoves;

        public Player()
        {
            _possibleMoves = new List<Move>();
        }

        public IEnumerable<Move> PossibleMoves
        {
            get { return _possibleMoves; }
        }

        public void Enrol(Game game)
        {
            _enrolledGame = game;
        }

        public void PublishAvailableMoves(List<Move> availableMoves)
        {
            _possibleMoves = availableMoves;
        }
    }
}