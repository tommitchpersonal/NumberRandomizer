namespace NumberRandomizerTests;

[TestFixture]
public class IntArrayExtensionsTests
{
    [Test]
    public void ShufflesCorrectly()
    {
        // Arrange
        var sut = new int[] {0, 1, 2, 3, 4};
        var originalSet = new HashSet<int>(sut);

        // Execute
        sut.Shuffle();

        // Assert
        var newSet = new HashSet<int>(sut);
        Assert.That(newSet != originalSet);

        foreach (var n in newSet)
        {
            Assert.That(originalSet.Contains(n));
        }
    }
}