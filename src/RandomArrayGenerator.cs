namespace NumberRandomizer;

public class RandomArrayGenerator : IRandomArrayGenerator
{
    public int[] CreateRandomArray(int lowestValue, int highestValue, int interval)
    {
        var arraySize = ((highestValue - lowestValue / interval)) + 1;

        var array = new int[arraySize];

        for (var i = lowestValue; i <= highestValue; i += interval)
        {
            array[i / interval] = i;
        }

        return array.Shuffle();
    }
}