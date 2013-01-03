using System.Linq;
using Moq;
using NUnit.Framework;

namespace BitFarm.Tests
{
    [TestFixture]
    public class Enrolling_players_in_a_game
    {
        [Test]
        public void I_can_enrol_a_player_and_they_will_show_up_on_the_players_list()
        {
            var subject = new Game();
            var stubPlayer = new Mock<Player>().SetupAllProperties().Object;

            subject.Enrol(stubPlayer);

            var result = subject.GetPlayers();
            Assert.That(result.Contains(stubPlayer));
        }

        [Test]
        public void When_I_have_not_started_a_game_no_moves_are_available()
        {
            var subject = new Game();

            var result = subject.GetAvailableMoves();
            Assert.That(result.Count(), Is.EqualTo(0));
        }

        [Test]
        public void When_I_start_a_game_11_actions_are_available()
        {
            var subject = new Game();
            
            subject.Start();
            
            var result = subject.GetAvailableMoves();
            Assert.That(result.Count(), Is.EqualTo(11));
        }
    }
}
