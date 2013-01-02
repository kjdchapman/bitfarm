using System.Collections.Generic;

namespace BitFarm.Domain.Stages
{
    public class DefaultRoundsFactory : IRoundsFactory
    {
        public IEnumerable<Round> GetRounds()
        {
            return new List<Round>();
        }
    }
}