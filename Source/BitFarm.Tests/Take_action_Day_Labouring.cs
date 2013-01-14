using System;
using BitFarm.Domain;
using NUnit.Framework;

namespace BitFarm.Tests
{
    [TestFixture]
    class Take_action_Day_Labouring
    {
        [Test]
        public void Given_the_game_has_started_then_I_can_day_labourer_for_wood()
        {
            var subject = new Game();
            subject.Start();

            subject.DayLabour("Wood");
        }

        [Test]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Given_the_game_has_started_when_I_try_to_day_labour_for_gold_then_an_exception_will_be_thrown()
        {
            var subject = new Game();
            subject.Start();

            subject.DayLabour("Gold");
        }
        
        [Test]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Given_the_game_has_not_started_when_I_try_to_day_labour_then_an_exception_will_be_thrown()
        {
            var subject = new Game();
            
            subject.DayLabour("Wood");
        }

        [Test]
        [Description("Then I will have one food, one wood, zero stone, zero reed.")]
        public void Given_its_my_first_move_of_the_game_when_I_day_labour_for_wood_then_I_will_have_the_correct_resources()
        {
            var subject = new Game();
            subject.Start();

            subject.DayLabour("Wood");

            var result = subject.GetResources();
            Assert.That(result.Food, Is.EqualTo(1));
            Assert.That(result.Wood, Is.EqualTo(1));
            Assert.That(result.Stone, Is.EqualTo(0));
            Assert.That(result.Reed, Is.EqualTo(0));
        }
    }
}
