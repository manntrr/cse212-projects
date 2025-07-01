public static class Divisors
{
    /// <summary>
    /// Entry point for the Divisors class
    /// </summary>
    public static void Run()
    {
        List<int> list = FindDivisors(80);
        Console.WriteLine("<List>{" + string.Join(", ", list) + "}"); // <List>{1, 2, 4, 5, 8, 10, 16, 20, 40}
        List<int> list1 = FindDivisors(79);
        Console.WriteLine("<List>{" + string.Join(", ", list1) + "}"); // <List>{1}
    }

    /// <summary>
    /// Create a list of all divisors for a number including 1
    /// and excluding the number itself. Modulo will be used
    /// to test divisibility.
    /// </summary>
    /// <param name="number">The number to find the divisor</param>
    /// <returns>List of divisors</returns>
    private static List<int> FindDivisors(int number)
    {
        List<int> results = new();
        int max = number / 2;
        results.Add(1);
        int current = 2;
        while (current < max)
        {
            if (number % current == 0)
            {
                results.Add(current);
                max = number / current;
            }
            current += 1;
        }
        for (int index = results.Count; index > 1; index--)
        {
            results.Add(number / results[index - 1]);
        }
        return results;
    }
}