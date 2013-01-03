using System.Linq;
using BitFarm.Domain;
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
            subject.Enrol("Kyle");

            var result = subject.GetPlayers();
            Assert.That(result.Contains("Kyle"));
        }
    }
}
