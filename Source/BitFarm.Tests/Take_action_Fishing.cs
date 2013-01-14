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
        public void Given_its_my_first_move_of_the_game_when_I_fish_then_will_have_one_food()
        {
            var subject = new Game();
            subject.Start();

            subject.Fish();

            var result = subject.GetResources();
            Assert.That(result.Food, Is.EqualTo(1));
        }

        [Test]
        public void Given_its_round_2_and_noone_has_yet_fished_when_I_fish_then_I_will_have_three_food()
        {
            throw new NotImplementedException();
        }

        [Test]
        public void Given_its_round_3_and_noone_has_yet_fished_when_I_fish_then_I_will_have_three_food()
        {
            throw new NotImplementedException();
        }

        [Test]
        public void Given_its_round_7_and_noone_has_yet_fished_when_I_fish_then_I_will_have_three_food()
        {
            throw new NotImplementedException();
        }

        [Test]
        public void Given_its_round_14_and_noone_has_yet_fished_when_I_fish_then_I_will_have_three_food()
        {
            throw new NotImplementedException();
        }
    }
}
