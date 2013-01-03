using BitFarm.Domain.Messages;

namespace BitFarm.Domain.Interfaces
{
    public interface IMessageHub
    {
        void Send(Message availableMovesEvent);
    }
}