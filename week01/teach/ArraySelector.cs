public static class ArraySelector
{
    public static void Run()
    {
        var l1 = new[] { 1, 2, 3, 4, 5 };
        var l2 = new[] { 2, 4, 6, 8, 10 };
        var select = new[] { 1, 1, 1, 2, 2, 1, 2, 2, 2, 1 };
        var intResult = ListSelector(l1, l2, select);
        Console.WriteLine("<int[]>{" + string.Join(", ", intResult) + "}"); // <int[]>{1, 2, 3, 2, 4, 4, 6, 8, 10, 5}
    }

    private static int[] ListSelector(int[] list1, int[] list2, int[] select)
    {
        int list1Counter = 0;
        int list2Counter = 0;
        int[] result = new int[select.Length];
        for (int index = 0; index < select.Length; index++)
        {
            if (select[index] == 1 && list1Counter < list1.Length)
            {
                result[index] = list1[list1Counter];
                list1Counter++;
            }
            else if (select[index] == 2 && list2Counter < list2.Length)
            {
                result[index] = list2[list2Counter];
                list2Counter++;
            }
            else
            {
                throw new ArgumentException("Select array contains invalid value or there are not enough elements in the source lists.");
            }
        }
        return result;
    }
}