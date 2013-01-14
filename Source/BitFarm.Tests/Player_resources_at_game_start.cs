using System;
using BitFarm.Domain;
using NUnit.Framework;

namespace BitFarm.Tests
{
    [TestFixture]
    class Player_resources_at_game_start
    {
        [Test]
        public void At_the_beginning_of_a_one_player_game_the_player_has_no_food()
        {
            var subject = new Game();
            subject.Start();

            var result = subject.GetResources();

            Assert.That(result.Food, Is.EqualTo(0));
        }

        [Test]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Trying_to_get_resources_when_the_game_has_not_started_will_throw_an_exception()
        {
            var subject = new Game();

            subject.GetResources();
        }

    }
}
