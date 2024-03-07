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
            Assert.That(statistics.Total(), Is.EqualTo(0));

            // //Arrange
            // ArrayStatistics statistics = new ArrayStatistics(new int[] {1, 2, 3});
            // //Act
            // int sum = statistics.Total();
            // //Assert
            // Assert.That(sum, Is.EqualTo(6));
        }

        [TestCase(new int[] { 1, 2, 3 }, 0, false, TestName = "Test Contains - Lower Outbound")]
        [TestCase(new int[] { 1, 2, 3 }, 1, true, TestName = "Test Contains - Inbound")]
        [TestCase(new int[] { 1, 2, 3 }, 2, true, TestName = "Test Contains - Inbound")]
        [TestCase(new int[] { 1, 2, 3 }, 3, true, TestName = "Test Contains - Inbound")]
        [TestCase(new int[] { 1, 2, 3 }, 4, false, TestName = "Test Contains - Upper Outbound")]
        public void TestContains(int[] input, int number, bool output)
        {
            ArrayStatistics statistics = new ArrayStatistics(input);
            Assert.That(statistics.Contains(number), Is.EqualTo(output));
        }

        [TestCase(new int[] { 1, 2, 3 }, true, TestName = "Test Sorted - Sorted")]
        [TestCase(new int[] { 1, 1, 1 }, true, TestName = "Test Sorted - Same number")]
        [TestCase(new int[] { 3, 2, 1 }, false, TestName = "Test Sorted - Not Sorted")]
        public void TestSorted(int[] input, bool output)
        {
            ArrayStatistics statistics = new ArrayStatistics(input);
            Assert.That(statistics.Sorted(), Is.EqualTo(output));
        }

        [TestCase(new int[] { 3, 2, 1 }, 2, 0, TestName = "Test First Greater - First one is greater")]
        [TestCase(new int[] { 1, 1, 1 }, 2, -1, TestName = "Test First Greater - There is no greater")]
        [TestCase(new int[] { 1, 2, 3 }, 2, 2, TestName = "Test First Greater - Last one is greater")]
        [TestCase(new int[] { 1, 2, 3 }, 1, 1, TestName = "Test First Greater - Second and Last ones are greater")]
        public void TestFirstGreater(int[] input, int number, int output)
        {
            ArrayStatistics statistics = new ArrayStatistics(input);
            Assert.That(statistics.FirstGreater(number), Is.EqualTo(output));
        }
    }
}