using System.Collections.Generic;
using BitFarm.Domain.Stages;

namespace BitFarm.Domain.Interfaces
{
    public interface IRoundsFactory
    {
        IEnumerable<Round> GetRounds();
    }
}