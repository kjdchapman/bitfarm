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
            _actionSpaces = new List<ActionSpace>
            {
                ActionSpace.Build_Rooms_And_Or_Build_Stables,
                ActionSpace.Build_Stable_And_Or_Bake_Bread,
                ActionSpace.Day_Labourer,
                ActionSpace.Fishing,
                ActionSpace.One_Clay_Stockpile,
                ActionSpace.One_Reed_Stockpile,
                ActionSpace.Plow_One_Field_And_Or_Sow,
                ActionSpace.Starting_Player_And_Storehouse,
                ActionSpace.Take_One_Grain,
                ActionSpace.Three_Wood_Stockpile
            };
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