using System.Collections.Generic;
using BitFarm.Domain.Interfaces;
using BitFarm.Tests;

namespace BitFarm.Domain.Stages
{
    public class DefaultRoundsFactory : IRoundsFactory
    {
        public IEnumerable<Round> GetRounds()
        {
            return new List<Round>
            {
                new Round(),
                new Round(),
                new Round(),
                new Round(),
                new Round(),
                
                new Round(),
                new Round(),
                new Round(),
                new Round(),
                new Round(),
                    
                new Round(),
                new Round(),
                new Round(),
            };
        }
    }
}