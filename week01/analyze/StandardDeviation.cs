/// <summary>
/// These 3 functions will (in different ways) calculate the standard
/// deviation from a list of numbers.  The standard deviation
/// is defined as the square root of the variance.  The variance is 
/// defined as the average of the squared differences from the mean.
/// </summary>
public static class StandardDeviation
{
    public static void Run()
    {
        var numbers = new[] { 600, 470, 170, 430, 300 };
        Console.WriteLine(StandardDeviation1(numbers)); // Should be 147.322 
        Console.WriteLine(StandardDeviation2(numbers)); // Should be 147.322 
        Console.WriteLine(StandardDeviation3(numbers)); // Should be 147.322 
    }

    // 1 + 1 + n + 1 + 1 + n + 1 + 1 = 2n+ 6 = 2n = n ==> O(n)
    private static double StandardDeviation1(int[] numbers)
    {
        // 1
        var total = 0.0;
        // 1
        var count = 0;
        // n
        foreach (var number in numbers)
        {
            total += number;
            count += 1;
        }

        // 1
        var avg = total / count;
        // 1
        var sumSquaredDifferences = 0.0;
        // n
        foreach (var number in numbers)
        {
            sumSquaredDifferences += Math.Pow(number - avg, 2);
        }

        // 1
        var variance = sumSquaredDifferences / count;
        // 1
        return Math.Sqrt(variance);
    }

    // 1+ 1+ n^2 + 1+ 1= n^2 + 4 = n^2 ==> O(n^2)
    private static double StandardDeviation2(int[] numbers)
    {
        // 1
        var sumSquaredDifferences = 0.0;
        // 1
        var countNumbers = 0;
        // n * (1 + 1 + n + 1 + 1 + 1) = n * (n+5) = n^2
        foreach (var number in numbers)
        {
            // 1
            var total = 0;
            // 1
            var count = 0;
            // n * 2 = 2n = n
            foreach (var value in numbers)
            {
                // 1
                total += value;
                // 1
                count += 1;
            }

            // 1
            var avg = total / count;
            // 1
            sumSquaredDifferences += Math.Pow(number - avg, 2);
            // 1
            countNumbers += 1;
        }

        // 1
        var variance = sumSquaredDifferences / countNumbers;
        // 1
        return Math.Sqrt(variance);
    }

    // 1+ 1+ 1+ n+ 1+ 1 = n+5 = n ==> O(n)
    private static double StandardDeviation3(int[] numbers)
    {
        // 1
        var count = numbers.Length;
        // 1
        var avg = (double)numbers.Sum() / count;
        // 1
        var sumSquaredDifferences = 0.0;
        // n * 1 = n
        foreach (var number in numbers)
        {
            // 1
            sumSquaredDifferences += Math.Pow(number - avg, 2);
        }

        // 1
        var variance = sumSquaredDifferences / count;
        // 1
        return Math.Sqrt(variance);
    }
}