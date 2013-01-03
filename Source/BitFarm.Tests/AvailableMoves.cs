using BitFarm.Domain;
using BitFarm.Domain.Interfaces;
using BitFarm.Domain.Messages.Events;
using Moq;
using NUnit.Framework;

namespace BitFarm.Tests
{
    [TestFixture]
    public class AvailableMoves
    {
        [Test]
        public void On_game_start_event_the_board_raises_an_available_moves_event()
        {
            var subject = new Board();

            var hubMocker = new Mock<IMessageHub>();
            
            subject.Join(hubMocker.Object);
            subject.Handle(new GameStartEvent());

            hubMocker.Verify(hm => hm.Send(new AvailableMovesEvent()));
        }
    }
}