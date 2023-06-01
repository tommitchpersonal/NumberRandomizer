namespace NumberRandomizer;

public interface IRandomArrayGenerator
{
    public int[] CreateRandomArray(int lowestValue, int highestValue, int interval);
}
