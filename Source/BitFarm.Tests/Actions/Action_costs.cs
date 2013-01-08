using System.Linq;
using NUnit.Framework;

namespace BitFarm.Tests.Actions
{
    [TestFixture]
    public class Costs_of_sowing
    {
        [Test]
        public void Sowing_can_cost_one_grain()
        {
            var subject = new GameAction("sow");

            var result = subject.Costs
                .Where(c => c.ResourceType == "grain")
                .Count(c => c.Amount == 1);

            Assert.That(result, Is.EqualTo(1));
        }

        [Test]
        public void Sowing_can_cost_two_grain()
        {
            var subject = new GameAction("sow");

            var result = subject.Costs
                .Where(c => c.ResourceType == "grain")
                .Count(c => c.Amount == 2);

            Assert.That(result, Is.EqualTo(1));
        }

        [Test]
        public void Sowing_can_cost_four_grain()
        {
            var subject = new GameAction("sow");

            var result = subject.Costs
                .Where(c => c.ResourceType == "grain")
                .Count(c => c.Amount == 4);

            Assert.That(result, Is.EqualTo(1));
        }

        [Test]
        public void Sowing_can_cost_eight_grain()
        {
            var subject = new GameAction("sow");

            var result = subject.Costs
                .Where(c => c.ResourceType == "grain")
                .Count(c => c.Amount == 8);

            Assert.That(result, Is.EqualTo(1));
        }

        [Test]
        public void Sowing_can_cost_thirteen_grain()
        {
            var subject = new GameAction("sow");

            var result = subject.Costs
                .Where(c => c.ResourceType == "grain")
                .Count(c => c.Amount == 13);

            Assert.That(result, Is.EqualTo(1));
        }

        [Test]
        public void Sowing_can_cost_one_vegetable()
        {
            var subject = new GameAction("sow");

            var result = subject.Costs
                .Where(c => c.ResourceType == "vegetable")
                .Count(c => c.Amount == 1);

            Assert.That(result, Is.EqualTo(1));
        }

        [Test]
        public void Sowing_can_cost_two_vegetables()
        {
            var subject = new GameAction("sow");

            var result = subject.Costs
                .Where(c => c.ResourceType == "vegetable")
                .Count(c => c.Amount == 2);

            Assert.That(result, Is.EqualTo(1));
        }

        [Test]
        public void Sowing_can_cost_four_vegetables()
        {
            var subject = new GameAction("sow");

            var result = subject.Costs
                .Where(c => c.ResourceType == "vegetable")
                .Count(c => c.Amount == 4);

            Assert.That(result, Is.EqualTo(1));
        }

        [Test]
        public void Sowing_can_cost_eight_vegetables()
        {
            var subject = new GameAction("sow");

            var result = subject.Costs
                .Where(c => c.ResourceType == "vegetable")
                .Count(c => c.Amount == 8);

            Assert.That(result, Is.EqualTo(1));
        }

        [Test]
        public void Sowing_can_cost_thirteen_vegetables()
        {
            var subject = new GameAction("sow");

            var result = subject.Costs
                .Where(c => c.ResourceType == "vegetable")
                .Count(c => c.Amount == 13);

            Assert.That(result, Is.EqualTo(1));
        }
    }
}
