using System;
using System.Collections.Generic;
using BitFarm.Domain.Moves;

namespace BitFarm.Domain
{
    public class Game
    {
        private List<ActionSpace> _actionSpaces;
        private Resources _resources;
        private object _board;

        public Game()
        {
            _actionSpaces = new List<ActionSpace>();
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

            InitialiseResourceList();
            InitialiseBoard();
        }

        private void InitialiseBoard()
        {
            _board = new object();
        }

        private void InitialiseResourceList()
        {
            _resources = new Resources {Food = 0};
        }

        public List<ActionSpace> GetActionSpaces()
        {
            return _actionSpaces;
        }

        public Resources GetResources()
        {
            if (_resources == null) throw new InvalidOperationException();

            return _resources;
        }

        public void DayLabour(string resourceType)
        {
            if (_board == null) throw new InvalidOperationException();

            switch (resourceType.ToLower())
            {
                case "wood":
                    _resources.Wood++;
                    break;
                case "clay":
                    _resources.Clay++;
                    break;
                case "reed":
                    _resources.Reed++;
                    break;
                case "stone":
                    _resources.Stone++;
                    break;

                default:
                    throw new ArgumentOutOfRangeException();
            }

            _resources.Food++;

        }

        public void Fish()
        {
            throw new NotImplementedException();
        }
    }
}