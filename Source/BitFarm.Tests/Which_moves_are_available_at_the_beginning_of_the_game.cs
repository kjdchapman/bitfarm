using System.Linq;
using BitFarm.Domain;
using BitFarm.Domain.Moves;
using NUnit.Framework;

namespace BitFarm.Tests
{
    [TestFixture]
    public class Availability_of_moves
    {
        [Test]
        public void One_of_the_basic_available_moves_is_taking_1_grain()
        {
            var subject = new Game();
            subject.Start();

            var result = subject.GetAvailableMoves();

            Assert.That(result.Any(r => r.ID == MoveType.TakeOneGrain));
        }
    }
}
