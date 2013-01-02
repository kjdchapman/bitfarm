using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using BitFarm.Domain;
using BitFarm.Domain.Stages;
using Moq;
using NUnit.Framework;

namespace BitFarm.Tests
{
    // Agricola has stages, which divide further into rounds. 
    // After each round, a new action is available. 
    // After each stage, the harvest steps must be taken.
    [TestFixture]
    public class StagesAndRounds
    {
        [Test]
        public void The_default_stages_factory_produces_13_rounds()
        {
            var stageFactory = new DefaultRoundsFactory();
            var result = stageFactory.GetRounds();

            Assert.That(result.Count(), Is.EqualTo(13));
        }
    }
}
