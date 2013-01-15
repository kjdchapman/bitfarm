using System;
using BitFarm.Domain;
using NUnit.Framework;

namespace BitFarm.Tests
{
    [TestFixture]
    public class Advancing_through_the_rounds
    {
        [Test]
        [ExpectedException(typeof(InvalidOperationException))]
        public void If_the_game_has_not_started_then_requesting_the_current_round_will_throw_an_exception()
        {
            var game = new Game();

            var result = game.GetCurrentRound();
        }

        [Test]
        public void If_the_game_has_started_it_is_round_one()
        {
            var game = new Game();
            game.Start();

            var result = game.GetCurrentRound();
            
            Assert.That(result, Is.EqualTo(1));
        }

        [Test]
        public void I_can_advance_the_game_to_the_next_round()
        {
            var game = new Game();
            game.Start();

            game.NextRound();
        }

        [Test]
        public void Given_the_game_has_just_started_when_I_advance_to_the_next_round_then_it_will_be_round_2()
        {
            var game = new Game();
            game.Start();

            game.NextRound();

            var result = game.GetCurrentRound();

            Assert.That(result, Is.EqualTo(2));
        }

        [Test]
        public void Given_the_game_has_just_started_when_I_advance_to_the_next_round_twice_then_it_will_be_round_3()
        {
            var game = new Game();
            game.Start();

            game.NextRound();
            game.NextRound();

            var result = game.GetCurrentRound();

            Assert.That(result, Is.EqualTo(3));
        }

        [Test]
        public void Given_the_game_has_just_started_when_I_advance_to_the_next_round_thirteen_times_then_it_will_be_round_14()
        {
            var game = new Game();
            game.Start();

            for (int i = 0; i < 13; i++)
            {
                game.NextRound();
            }

            var result = game.GetCurrentRound();

            Assert.That(result, Is.EqualTo(14));
        }

        [Test]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Given_the_game_has_just_started_when_I_advance_to_the_next_round_fourteen_times_then_an_exception_will_be_thrown()
        {
            var game = new Game();
            game.Start();

            for (int i = 0; i < 14; i++)
            {
                game.NextRound();
            }
        }
    }
}
