using System;
using NUnit.Framework;

namespace BitFarm.Tests.Actions
{
    public class Action_effects
    {
        [Test]
        public void If_one_grain_was_spent_sowing_adds_three_grain_to_a_plowed_field()
        {
            throw new NotImplementedException();
        }

        [Test]
        public void If_one_vegetable_was_spent_sowing_adds_two_vegetables_to_a_plowed_field()
        {
            throw new NotImplementedException();
        }

        [Test]
        [Description("If one grain and one vegetable were spent sowing then three grain and two vegetables, " +
                     "then one plowed field will have three grain added to it," +
                     "and a second plowed field will have two vegetables added to it.")]
        public void If_one_grain_and_one_vegetable_were_spent_sowing_then_the_players_board_will_be_updated_appropriately()
        {
            throw new NotImplementedException();
        }
    }
}
