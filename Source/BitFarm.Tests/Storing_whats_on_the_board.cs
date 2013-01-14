using BitFarm.Domain;
using Moq;
using NUnit.Framework;

namespace BitFarm.Tests
{
    [TestFixture]
    public class Storing_whats_on_the_board
    {
        [Test]
        public void I_can_set_which_board_the_game_uses_at_instantiation()
        {
            var game = new Game(new Mock<IBoardFactory>().Object);
        }
    }
}
