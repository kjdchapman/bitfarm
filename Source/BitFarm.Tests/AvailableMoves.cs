using System.Linq;
using BitFarm.Domain;
using Moq;
using NUnit.Framework;

namespace BitFarm.Tests
{
    [TestFixture]
    public class AvailableMoves
    {
        [Test]
        public void When_a_player_is_first_created_it_has_no_available_moves()
        {
            var player = new Player();
            
            Assert.That(player.PossibleMoves.Count(), Is.EqualTo(0));
        }

        [Test]
        public void When_a_game_is_started_the_move_to_take_1_grain_is_available()
        {
            var player = new Player();
            var game = new Game();

            game.Enrol(player);
            game.Start();

            Assert.That(player.PossibleMoves.Any(pm => pm.GetType() == typeof(TakeOneGrain)));
        }
    }
}