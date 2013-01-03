using System;
using BitFarm.Domain.Messages;
using BitFarm.Domain.Messages.Commands;
using BitFarm.Domain.Messages.Events;

namespace BitFarm.Domain
{
    public class Board : HubMember
    {
        protected override void HandleEvent(Event @event)
        {
            if (@event.GetType() == typeof (GameStartEvent))
            {
                Send(new AvailableMovesEvent());
            }
        }

        protected override void HandleCommand(Command command)
        {
            throw new NotImplementedException();
        }
    }
}