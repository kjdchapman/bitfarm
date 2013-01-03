using System.Collections.Generic;

namespace BitFarm.Tests
{
    public class Game
    {
        private readonly List<Player> _players;
        private List<Move> _availableMoves;

        public Game()
        {
            _players = new List<Player>();
            _availableMoves = new List<Move>();
        }

        public void Enrol(Player player)
        {
            _players.Add(player);
        }

        public void Start()
        {
            _availableMoves = new List<Move>();

            for (int i = 0; i < 11; i++)
            {
                _availableMoves.Add(new Move());
            }
        }

        public List<Move> GetAvailableMoves()
        {
            return _availableMoves;
        }

        public IEnumerable<Player> GetPlayers()
        {
            return _players;
        }
    }
}