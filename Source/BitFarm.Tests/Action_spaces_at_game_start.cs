using System.Collections.Generic;
using BitFarm.Domain;
using BitFarm.Domain.Moves;
using NUnit.Framework;

namespace BitFarm.Tests
{
    [TestFixture]
    public class Action_spaces_at_game_start
    {
        private List<ActionSpace> _result;

        [SetUp]
        public void Start_a_game()
        {
            var game = new Game();
            game.Start();

            _result = game.GetActionSpaces();
        }

        [Test]
        public void Take_1_Grain_is_available()
        {
            Assert.That(_result.Contains(ActionSpace.Take_One_Grain));
        }

        [Test]
        public void Build_Rooms_And_Or_Build_Stables_is_available()
        {
            Assert.That(_result.Contains(ActionSpace.Build_Rooms_And_Or_Build_Stables));
        }

        [Test]
        public void Starting_Player_And_Storehouse_is_available()
        {
            Assert.That(_result.Contains(ActionSpace.Starting_Player_And_Storehouse));
        }

        [Test]
        public void Plow_One_Field_And_Or_Sow_is_available()
        {
            Assert.That(_result.Contains(ActionSpace.Plow_One_Field_And_Or_Sow));
        }
        
        [Test]
        public void Build_Stable_And_Or_Bake_Bread_is_available()
        {
            Assert.That(_result.Contains(ActionSpace.Build_Stable_And_Or_Bake_Bread));
        }
    }
}
