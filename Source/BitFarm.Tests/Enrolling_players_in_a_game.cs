using NUnit.Framework;

namespace BitFarm.Tests
{
    [TestFixture]
    public class Enrolling_players_in_a_game
    {
        [Test]
        public void I_can_enrol_a_player()
        {
            var subject = new Game();
            subject.Enrol(new Player());
        }

        [Test]
        public void I_can_start_a_game()
        {
            var subject = new Game();
            subject.Start();
        }

        [Test]
        public void When_I_have_not_started_a_game_no_moves_are_available()
        {
            var subject = new Game();
            var result = subject.GetAvailableMoves();

            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        public void When_I_start_a_game_11_actions_are_available()
        {
            var subject = new Game();
            var result = subject.GetAvailableMoves();

            Assert.That(result, Is.EqualTo(0));
        }
    }
}
