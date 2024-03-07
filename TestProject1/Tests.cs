using System;
using NUnit.Framework;
using Week3;

namespace TestProject1
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void TestConstructor()
        {
            ArrayStatistics statistics = new ArrayStatistics(null);
            // Assert.That(statistics.Total(), Is.EqualTo(6));
            Assert.That(
                () => statistics.Total(),
                Throws.TypeOf<NullReferenceException>()
                );

            // //Arrange
            // ArrayStatistics statistics = new ArrayStatistics(new int[] {1, 2, 3});
            // //Act
            // int sum = statistics.Total();
            // //Assert
            // Assert.That(sum, Is.EqualTo(6));
        }
    }
}