namespace NumberRandomizerTests;

[TestFixture]
public class RandomArrayGeneratorTests
{
    [Test]
    public void GeneratesRandomArrayCorrectly()
    {
        // Arrange
        const int lowestValue = 0;
        const int highestValue = 9;
        const int interval = 1;

        // Execute
        var sut = new RandomArrayGenerator();
        var output = sut.CreateRandomArray(lowestValue, highestValue, interval);

        // Assert
        Assert.That(output.Min() == lowestValue);
        Assert.That(output.Max() == highestValue);
        Assert.That(output.Length == (highestValue + 1) - lowestValue);

        for (int i = lowestValue; i <= highestValue; i += interval)
        {
            Assert.That(output.Contains(i));
        }
    }
}