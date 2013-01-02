using System.Collections.Generic;

namespace BitFarm.Domain.Interfaces
{
    public interface IPlayer
    {
        IEnumerable<Move> GetPossibleMoves { get; }
        void Enrol(Game game);
        void UpdatePossibleMoves(List<Move> availableMoves);
    }
}