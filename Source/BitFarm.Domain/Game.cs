using System.Collections.Generic;
using BitFarm.Domain.Moves;

namespace BitFarm.Domain
{
    public class Game
    {
        private readonly List<string> _players;
        private List<ActionSpace> _actionSpaces;

        public Game()
        {
            _players = new List<string>();
            _actionSpaces = new List<ActionSpace>();
        }

        public void Enrol(string player)
        {
            _players.Add(player);
        }

        public void Start()
        {
            _actionSpaces = new List<ActionSpace>();

            for (int i = 0; i < 11; i++)
            {
                _actionSpaces.Add(ActionSpace.Take_One_Grain);
            }
        }

        public List<ActionSpace> GetActionSpaces()
        {
            return _actionSpaces;
        }

        public IEnumerable<string> GetPlayers()
        {
            return _players;
        }
    }
}