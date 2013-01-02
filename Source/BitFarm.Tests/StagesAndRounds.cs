using System;
using System.Linq;
using BitFarm.Domain;
using BitFarm.Domain.Stages;
using NUnit.Framework;

namespace BitFarm.Tests
{
    // Agricola has stages, which divide further into rounds. 
    // After each round, a new action is available. 
    // After each stage, the harvest steps must be taken.
    [TestFixture]
    public class StagesAndRounds
    {
        [Test]
        public void When_a_game_is_started_it_is_stage_one()
        {
            var game = new Game();
            Assert.That(game.CurrentStage.Number, Is.EqualTo(1));
        }

        [Test]
        public void When_a_game_is_started_it_is_round_one()
        {
            var game = new Game();
            Assert.That(game.CurrentRound.Number, Is.EqualTo(1));
        }

        [Test]
        public void The_default_stages_factory_produces_6_stages()
        {
            var stageFactory = new DefaultRoundsFactory();
            var result = stageFactory.GetRounds();

            Assert.That(result.Count(), Is.EqualTo(6));
        }
    }
}
