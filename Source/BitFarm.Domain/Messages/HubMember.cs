using System;
using System.Collections.Generic;
using BitFarm.Domain.Interfaces;
using BitFarm.Domain.Messages.Commands;
using BitFarm.Domain.Messages.Events;

namespace BitFarm.Domain.Messages
{
    public abstract class HubMember
    {
        protected List<IMessageHub> _subscribedHubs;

        public void Handle(Message message)
        {
            if (message is Event)
            {
                HandleEvent(message as Event);
            }
            else if (message is Command)
            {
                HandleCommand(message as Command);
            }
            else
            {
                throw new ArgumentException("Cannot handle message (expected Event or Command)");
            }
        }

        public void Join(IMessageHub messageHub)
        {
            if (_subscribedHubs == null)
            {
                _subscribedHubs = new List<IMessageHub>();
            }

            _subscribedHubs.Add(messageHub);
        }

        public void Send(Message message)
        {
            _subscribedHubs.ForEach(sh => sh.Send(message));
        }

        protected abstract void HandleEvent(Event @event);
        protected abstract void HandleCommand(Command command);
    }
}