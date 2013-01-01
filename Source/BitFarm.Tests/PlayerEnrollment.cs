using System;
using System.Linq;
using Moq;
using NUnit.Framework;

namespace BitFarm.Tests
{
    [TestFixture]
    public class PlayerEnrollment
    {
        [Test]
        [ExpectedException(typeof(InvalidOperationException))]
        public void I_cannot_start_a_game_of_agricola_without_enrolling_players()
        {
            var game = new AgricolaGame();
            game.Start();
        }

        [Test]
        public void I_can_start_a_game_of_agricola_with_one_enrolled_player()
        {
            var player = GetMockPlayer();
            var game = new AgricolaGame();
            game.Enrol(player);
            game.Start();
        }

        [Test]
        public void I_can_start_a_game_of_agricola_with_two_enrolled_players()
        {
            var game = new AgricolaGame();

            for (int i = 0; i < 2; i++)
            {
                game.Enrol(GetMockPlayer());
            }

            game.Start();
        }

        [Test]
        public void I_can_start_a_game_of_agricola_with_three_enrolled_players()
        {
            var game = new AgricolaGame();

            for (int i = 0; i < 3; i++)
            {
                game.Enrol(GetMockPlayer());
            }

            game.Start();
        }

        [Test]
        public void I_can_start_a_game_of_agricola_with_four_enrolled_players()
        {
            var game = new AgricolaGame();

            for (int i = 0; i < 4; i++)
            {
                game.Enrol(GetMockPlayer());
            }

            game.Start();
        }

        [Test]
        public void I_can_start_a_game_of_agricola_with_five_enrolled_players()
        {
            var game = new AgricolaGame();

            for (int i = 0; i < 5; i++)
            {
                game.Enrol(GetMockPlayer());
            }

            game.Start();
        }

        [Test]
        [ExpectedException(typeof(InvalidOperationException))]
        public void I_cannot_enrol_a_sixth_player()
        {
            var game = new AgricolaGame();

            for (int i = 0; i < 6; i++)
            {
                game.Enrol(GetMockPlayer());
            }
        }

        [Test]
        public void When_I_enrol_a_player_it_is_added_to_the_games_players_list()
        {
            var game = new AgricolaGame();
            var player = GetMockPlayer();

            game.Enrol(player);

            Assert.That(game.Players.First(), Is.EqualTo(player));
        }


        private AgricolaPlayer GetMockPlayer()
        {
            return new Mock<AgricolaPlayer>().SetupAllProperties().Object;
        }
    }
}
