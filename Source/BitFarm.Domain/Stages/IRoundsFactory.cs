using System.Collections.Generic;

namespace BitFarm.Domain.Stages
{
    public interface IRoundsFactory
    {
        IEnumerable<Round> GetRounds();
    }
}