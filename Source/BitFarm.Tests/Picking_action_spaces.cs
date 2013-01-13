using System;
using NUnit.Framework;

namespace BitFarm.Tests
{
    [TestFixture]
    class Picking_action_spaces
    {
        [Test]
        public void A_player_can_choose_the_day_labourer_action()
        {
            throw new NotImplementedException();
        }
        
        [Test]
        public void A_player_can_choose_the_day_labourer_action_alternate()
        {
            throw new NotImplementedException();
        }

        [Test]
        [ExpectedException(typeof(InvalidOperationException))]
        public void If_a_player_tries_to_day_labour_when_they_are_not_enrolled_an_exception_will_be_thrown()
        {
            throw new NotImplementedException();
        }

        [Test]
        [ExpectedException(typeof(InvalidOperationException))]
        public void If_a_player_tries_to_day_labour_when_the_game_has_not_started_an_exception_will_be_thrown()
        {
            throw new NotImplementedException();
        }

        [Test]
        public void If_the_player_chooses_the_day_labourer_action_with_wood_as_their_first_move_they_will_have_one_food_and_one_wood()
        {
            throw new NotImplementedException();
        }

        [Test]
        public void If_the_player_chooses_the_day_labourer_action_with_reed_as_their_first_move_they_will_have_one_food_and_one_reed()
        {
            throw new NotImplementedException();
        }

        [Test]
        public void If_the_player_chooses_the_day_labourer_action_with_stone_as_their_first_move_they_will_have_one_food_and_one_stone()
        {
            throw new NotImplementedException();
        }

        [Test]
        public void If_the_player_chooses_the_day_labourer_action_with_clay_as_their_first_move_they_will_have_one_food_and_one_clay()
        {
            throw new NotImplementedException();
        }
    }
}
