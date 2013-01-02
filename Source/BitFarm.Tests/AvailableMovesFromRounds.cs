using System.Collections.Generic;
using System.Linq;
using BitFarm.Domain;
using BitFarm.Domain.Interfaces;
using BitFarm.Domain.Stages;
using Moq;
using NUnit.Framework;

namespace BitFarm.Tests
{
    [TestFixture]
    public class AvailableMovesFromRounds
    {
        [Test]
        public void When_a_player_is_first_created_it_has_no_available_moves()
        {
            var player = new Player();
            
            Assert.That(player.GetPossibleMoves.Count(), Is.EqualTo(0));
        }

        [Test]
        public void Available_moves_published_to_players_at_game_start_are_derived_from_round_factory()
        {
            var inputMove = new Mock<Move>().Object;
            Move expectedMove = null;

            var roundStub = new Mock<Round>().SetupAllProperties().Object;
            roundStub.AvailableMove = inputMove;
            
            var roundsFactoryMocker = new Mock<IRoundsFactory>();
            roundsFactoryMocker.Setup(sfm => sfm.GetRounds()).Returns(new List<Round> { roundStub });

            var playerMocker = new Mock<IPlayer>();
            playerMocker.Setup(pm => pm.UpdatePossibleMoves(It.IsAny<List<Move>>())).Callback((List<Move> m) => expectedMove = m.Single());

            var game = new Game(roundsFactoryMocker.Object);
            game.Enrol(playerMocker.Object);
            game.Start();

            Assert.That(inputMove, Is.EqualTo(expectedMove));
        }
    }
}