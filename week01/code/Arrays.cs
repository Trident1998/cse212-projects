public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // First, we need to create a result array with a predefined capacity. 
        // The capacity is given in the arguments. Then, we create a for loop 
        // to set the number at each cell of the array by multiplying each 
        // index (i + 1) by the given number.
        double[] result = new double[length];
        for(int i = 0; i < length; i++) 
        result[i] = (i + 1) * number;

        return result;
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // Initialize two empty lists to hold the split parts of the data list. Then, create a for loop 
        // to get the last 'amount' elements from the original list and add them to the 'firstPart' list. 
        // Additionally, create a for loop to get the remaining elements from the front of the list 
        // and add them to the 'secondPart' list. 
        // Afterward, clear the original list to prepare for the rearranged data, and then add the 
        // 'firstPart' and 'secondPart' lists successively to the cleared list.
        List<int> firstPart = new List<int>();  
        List<int> secondPart = new List<int>(); 

        for (int i = data.Count() - amount; i < data.Count(); i++) 
        firstPart.Add(data[i]); 
        
        for (int i = 0; i < data.Count() - amount; i++)  
        secondPart.Add(data[i]); 

        data.Clear();
        data.AddRange(firstPart);
        data.AddRange(secondPart);
    }
}
