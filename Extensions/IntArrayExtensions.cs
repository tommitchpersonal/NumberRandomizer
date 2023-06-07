namespace NumberRandomizer;

public static class IntArrayExtensions
{
    public static int[] Shuffle(this int[] input)
    {
        var random = new Random();

        for (var i = input.Count() - 1; i > 0; i--)
        {
            var j = random.Next(0, i + 1);

            var input_i = input[i];
            var input_j = input[j];

            input[i] = input_j;
            input[j] = input_i;
        }

        return input;
    }
}