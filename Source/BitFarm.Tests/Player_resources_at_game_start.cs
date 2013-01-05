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
        [Description("One of the players has two food and the starting token, and the other has three food and no starting token")]
        public void At_the_beginning_of_a_two_player_game_the_players_have_the_right_resources()
        {
            
        }
    }
}
