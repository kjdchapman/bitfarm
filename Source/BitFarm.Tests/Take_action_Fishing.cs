using System;
using BitFarm.Domain;
using NUnit.Framework;

namespace BitFarm.Tests
{
    [TestFixture]
    class Take_action_Fishing
    {
        [Test]
        public void Given_the_game_has_started_then_I_can_fish()
        {
            var subject = new Game();
            subject.Start();

            subject.Fish();
        }

        [Test]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Given_the_game_has_not_started_when_I_try_to_fish_then_an_exception_will_be_thrown()
        {
            var subject = new Game();

            subject.Fish();
        }

        [Test]
        public void Given_its_round_one_when_I_fish_then_will_have_one_food()
        {
            var subject = GameAtRound(1);
            
            subject.Fish();

            var result = subject.GetResources();
            Assert.That(result.Food, Is.EqualTo(1));
        }

        [Test]
        public void Given_its_round_two_and_noone_has_yet_fished_when_I_fish_then_I_will_have_two_food()
        {
            var subject = GameAtRound(2);
            
            subject.Fish();

            var result = subject.GetResources();
            Assert.That(result.Food, Is.EqualTo(2));
        }

        [Test]
        public void Given_its_round_three_and_noone_has_yet_fished_when_I_fish_then_I_will_have_three_food()
        {
            var subject = GameAtRound(3);

            subject.Fish();

            var result = subject.GetResources();
            Assert.That(result.Food, Is.EqualTo(3));
        }

        [Test]
        public void Given_its_round_seven_and_noone_has_yet_fished_when_I_fish_then_I_will_have_seven_food()
        {
            var subject = GameAtRound(7);
            
            subject.Fish();

            var result = subject.GetResources();
            Assert.That(result.Food, Is.EqualTo(7));
        }

        [Test]
        public void Given_its_round_fourteen_and_noone_has_yet_fished_when_I_fish_then_I_will_have_fourteen_food()
        {
            var subject = GameAtRound(14);

            subject.Fish();

            var result = subject.GetResources();
            Assert.That(result.Food, Is.EqualTo(14));
        }

        [Test]
        public void Given_the_game_has_started_when_I_fish_in_all_of_the_first_three_rounds_then_I_will_have_three_food()
        {
            var subject = new Game();
            subject.Start();

            subject.Fish();
            subject.NextRound();
            subject.Fish();
            subject.NextRound();
            subject.Fish();
            subject.NextRound();

            var result = subject.GetResources();
            Assert.That(result.Food, Is.EqualTo(3));
        }

        private Game GameAtRound(int round)
        {
            var game = new Game();
            game.Start();

            for (int i = 1; i < round; i++)
            {
                game.NextRound();
            }

            return game;
        }
    }
}
