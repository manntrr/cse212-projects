public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    /// <plan>
    ///    example 1 input : number=2, length=8
    ///    example 1 output : {2, 4, 6, 8, 10, 12, 14, 16}
    ///    example 2 input : number=10, length=6
    ///    example 2 output : {10, 20, 30, 40, 50, 60}
    /// 
    ///   1. Create an array of doubles with the size of length
    ///   2. Create an index variable and set it to 0
    ///   3. Create a while loop that exits when index is equal to length
    ///     a. Inside the while loop, set the value of the array at the current index to be number * (index + 1)
    ///     b. Increment the index by 1
    ///   4. Return the array
    /// 
    /// </plan>
    public static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        ///  Create an array of doubles with the size of length
        double[] result = new double[length];
        ///  Create an index variable and set it to 0
        int index = 0;
        ///  Create a while loop that exits when index is equal to length
        while (index < length)
        {
            ///  set the value of the array at the current index to be number * (index + 1)
            result[index] = number * (index + 1);
            ///  Increment the index by 1
            index++;
        }
        ///  Return the array
        return result;
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    /// <plan>
    ///    example 1 input : data={9, 8, 7, 6, 5, 4, 3, 2, 1}, amount=8
    ///    example 1 output : {1, 9, 8, 7, 6, 5, 4, 3, 2}
    ///    example 2 input : data={9, 8, 7, 6, 5, 4, 3, 2, 1}, amount=5
    ///    example 2 output : {4, 3, 2, 1, 9, 8, 7, 6, 5}
    /// 
    ///   1. Create and Assign to the result list the slice of data from the results of the GetRange Function for the data beginning at amount to the end of the data list.
    ///   2. Create a for loop that starts at 0 and goes to amount - 1 using i as the index
    ///     a. Inside the for loop, add the element of data at index i to the end of the result list
    ///   3. set data to the result
    /// 
    /// </plan>
    public static void RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        ///   Create and Assign to the result list the slice of data from the results of the GetRange Function for the data beginning at amount to the end of the data list.
        ///   ***   based on errors and review in debug mode, I had to adjust the logic here to get the correct range,
        ///   starting the slice at the data list index representing the left most index to get the full amount of
        ///   elements matching the count of amount, then fixing the count to that same amount.
        List<int> result = data.GetRange(data.Count - amount, amount);
        ///   Create a for loop that starts at 0 and goes to amount - 1 using i as the index
        ///   ***  based on errors and review in debug mode, I had to adjust the logic here to get the correct range,
        ///   the start point remainded the same, where the count needed to change to the remainder of elements not
        ///   already retrieved in the first slice.
        foreach (int i in data.GetRange(0, data.Count - amount))
        {
            ///   Inside the for loop, add the element of data at index i to the end of the result list
            result.Add(i);
        }
        ///   set data to the result
        ///   ***  Based on errors and review in debug mode, I had to adjust the method of transfering data to the original
        ///   list.  My plan of just assigning the object did not pass back out of the function, so instead I changed to a
        ///   clean and copy results into the parameter variable in order to return the results as expected by the test cases.
        data.Clear();
        data.AddRange(result);
    }
}
