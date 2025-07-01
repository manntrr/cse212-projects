﻿public static class Sorting
{
    public static void Run()
    {
        var numbers = new[] { 3, 2, 1, 6, 4, 9, 8 };
        SortArray(numbers);
        Console.Out.WriteLine("int[]{{{0}}}", string.Join(", ", numbers)); //int[]{1, 2, 3, 4, 6, 8, 9}
    }

    // n * n * 1 = n^2
    private static void SortArray(int[] data)
    {
        // n
        for (var sortPos = data.Length - 1; sortPos >= 0; sortPos--)
        {
            // n
            for (var swapPos = 0; swapPos < sortPos; ++swapPos)
            {
                // n
                if (data[swapPos] > data[swapPos + 1])
                {
                    (data[swapPos + 1], data[swapPos]) = (data[swapPos], data[swapPos + 1]);
                }
            }
        }
    }
}