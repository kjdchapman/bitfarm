using System;
using System.Collections.Generic;

namespace BitFarm.Tests
{
    public class GameAction
    {
        public GameAction(string actionType)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ActionCost> Costs { get; private set; }
    }
}