using System;
using System.Collections.Generic;
using System.Linq;
using BitFarm.Domain.Interfaces;
using BitFarm.Domain.Moves;

namespace BitFarm.Domain
{
    public class Game
    {
        private readonly List<IPlayer> _players;
        private List<ActionSpace> _actionSpaces;
        private Dictionary<IPlayer, Resources> _resourcesList;

        public Game()
        {
            _players = new List<IPlayer>();
            _actionSpaces = new List<ActionSpace>();
        }

        public void Enrol(IPlayer player)
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

            InitialiseResourceList();
        }

        private void InitialiseResourceList()
        {
            _resourcesList = new Dictionary<IPlayer, Resources>();

            if (_players.Count == 1)
            {
                _resourcesList.Add(_players.Single(), new Resources {Foods = 0, StartingPlayer = true});
            }
            else
            {
                var firstPlayer = true;
                foreach (var player in _players)
                {
                    if (firstPlayer)
                    {
                        _resourcesList.Add(player, new Resources {Foods = 2, StartingPlayer = true});
                        firstPlayer = false;
                    }
                    else
                    {
                        _resourcesList.Add(player, new Resources {Foods = 3});
                    }
                }
            }
        }

        public List<ActionSpace> GetActionSpaces()
        {
            return _actionSpaces;
        }

        public IEnumerable<IPlayer> GetPlayers()
        {
            return _players;
        }

        public Resources GetResourcesFor(IPlayer player)
        {
            if (_resourcesList == null) throw new InvalidOperationException();

            if (!_resourcesList.ContainsKey(player)) throw new ArgumentException();

            return _resourcesList[player];
        }
    }
}