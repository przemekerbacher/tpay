using NUnit.Framework;

namespace ObslugaTPay.Tests
{
    public class HashCalculatorTests
    {
        private ObslugaTPay.Helpers.Contracts.IHashCalculator _md5SumCalculator;

        [SetUp]
        public void Setup()
        {
            _md5SumCalculator = new ObslugaTPay.Helpers.Implementations.HashCalculator();
        }

        [Test]
        public void CalculateShouldPass()
        {
            var expectedHash = "5385884285e4212eae02758fdc731b9e";
            string id = "ala";
            string amount = "ma";
            string crc = "kota";
            string code = "ala";

            var calculatedHash = _md5SumCalculator.Md5Sum(id, amount, crc, code);

            Assert.AreEqual(expectedHash, calculatedHash);
        }

        [Test]
        public void CalculateShouldFail()
        {
            var expectedHash = "5385884285e4212eae02758fdc731b9e";
            string id = "ma";
            string amount = "ala";
            string crc = "kota";
            string code = "ala";

            var calculatedHash = _md5SumCalculator.Md5Sum(id, amount, crc, code);

            Assert.AreNotEqual(expectedHash, calculatedHash);
        }

        [TestCase(null, null, null, null)]
        [TestCase("ala", "ma", "kota", null)]
        [TestCase(null, "ma", "kota", "ala")]
        [TestCase("ala", null, "kota", "ala")]
        [Test]
        public void CalculateWithMissingParameterShouldPass(string id, string amount, string crc, string code)
        {
            _md5SumCalculator.Md5Sum(id, amount, crc, code);

            Assert.Pass();
        }
        [TestCase(null)]
        [TestCase("")]
        [Test]
        public void CalclateWithoutValueShouldReturnNull(string data)
        {
            var result = _md5SumCalculator.TimeHash(data, null);
            
            Assert.That(result, Is.Null);
        }
    }
}