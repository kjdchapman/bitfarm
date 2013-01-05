using System;
using BitFarm.Domain;
using BitFarm.Domain.Interfaces;
using Moq;
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
            var stubPlayer = new Mock<IPlayer>().Object;
            subject.Enrol(stubPlayer);

            var result = subject.GetResourcesFor(stubPlayer);

            Assert.That(result.Foods, Is.EqualTo(0));
        }

        [Test]
        public void At_the_beginning_of_a_one_player_game_the_player_has_the_starting_player_token()
        {
            var subject = new Game();
            var stubPlayer = new Mock<IPlayer>().Object;
            subject.Enrol(stubPlayer);

            var result = subject.GetResourcesFor(stubPlayer);

            Assert.That(result.StartingPlayer, Is.EqualTo(true));
        }

        [Test]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Trying_to_get_resources_when_the_game_has_not_started_will_throw_an_exception()
        {
            var subject = new Game();
            var stubPlayer = new Mock<IPlayer>().Object;
            subject.Enrol(stubPlayer);

            subject.GetResourcesFor(stubPlayer);
        }

        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void Trying_to_get_resources_for_a_player_not_in_the_game_will_throw_an_exception()
        {
            var subject = new Game();
            var playerOne = new Mock<IPlayer>().Object;
            var playerTwo = new Mock<IPlayer>().Object;
            subject.Enrol(playerOne);

            subject.GetResourcesFor(playerTwo);
        }

        [Test]
        [Description("One of the players has two food and the starting token, and the other has three food and no starting token")]
        public void At_the_beginning_of_a_two_player_game_the_players_have_the_right_resources()
        {
            throw new NotImplementedException();    
        }
    }
}
