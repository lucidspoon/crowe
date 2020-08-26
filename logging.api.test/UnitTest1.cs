using NUnit.Framework;
using logging.api;
using System.Configuration;
using System;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            ILogger logger = LoggerFactory.GetLogger();

            Assert.That(logger, Is.Not.Null);
            
            logger.Log("Hello World!");

            Assert.Pass();
        }
    }
}