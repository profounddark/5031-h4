using System;

class MergeSortTest
{

    /// <summary>
    /// Combine takes an array that has been divided into two sorted sub-arrays
    /// and combines them into a single sorted array.
    /// </summary>
    /// <param name="sortArray">Array that contains two sorted sub-arrays</param>
    /// <param name="first">the index for the first element of the first
    /// sub-array</param>
    /// <param name="middle">the index of the last element of the first sub-array
    /// and predecessor to the first element of the second sub-array</param>
    /// <param name="last">the index of the last item of the second sub-array</param>
    private static void Combine(int[] sortArray, int first, int middle, int last)
    {
        int[] tempArray = new int[last - first + 1];

        int firstCount = first;
        int lastCount = middle + 1;
        int tempCount = 0;

        while ((firstCount <= middle) && (lastCount <= last))
        {
            if (sortArray[firstCount] < sortArray[lastCount])
            {
                tempArray[tempCount] = sortArray[firstCount];
                firstCount++;
            }
            else
            {
                tempArray[tempCount] = sortArray[lastCount];
                lastCount++;
            }
            tempCount++;
        }

        // One of the arrays isn't done, so go through each and finish.
        for (int i = firstCount; i <= middle; i++)
        {
            tempArray[tempCount] = sortArray[i];
            tempCount++;
        }
        for (int j = lastCount; j <= last; j++)
        {
            tempArray[tempCount] = sortArray[j];
            tempCount++;
        }

        // move the contents of teh temporary array into the original array
        for (int k = 0; k < tempArray.Length; k++)
        {
            sortArray[k + first] = tempArray[k];
        }

    }

    /// <summary>
    /// Sort is the recursive method for the MergeSort. It divides the
    /// array into two sub arrays, runs Sort on those sub-arrays, and
    /// then recombines the two sub-arrays into one sorted array.
    /// </summary>
    /// <param name="sortArray">the array to be sorted</param>
    /// <param name="first">the inedex of th efirst element in the
    /// array to be sorted.</param>
    /// <param name="last">the index of the last element in the array
    /// to be sorted</param>
    private static void Sort(int[] sortArray, int first, int last)
    {
        if (first < last)
        {
            int middle = (first + last) / 2;
            Sort(sortArray, first, middle);
            Sort(sortArray, middle + 1, last);
            Combine(sortArray, first, middle, last);

        }
    }

    /// <summary>
    /// MergeSort is the user friendly entry point to the Merge
    /// Sort algorithm. It performs a MergeSort on the provided
    /// array.
    /// </summary>
    /// <param name="sortArray">the array to be sorted</param>
    public static void MergeSort(int[] sortArray)
    {
        Sort(sortArray, 0, sortArray.Length - 1);
    }

    /// <summary>
    /// PrintArray prints out the contents of an integer array.
    /// </summary>
    /// <param name="printArray">the array to be printed</param>
    public static void PrintArray(int[] printArray)
    {
        Console.WriteLine("Contents of Array:");
        Console.Write("{ ");
        for (int i = 0; i < printArray.Length; i++)
        {
            Console.Write(printArray[i]);
            if (i < printArray.Length - 1)
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine(" }");
    }

    /// <summary>
    /// TestArray runs a test of the MergeSort on the given array.
    /// </summary>
    /// <param name="testCase">the number of the test case, for printing</param>
    /// <param name="testArray">the array to test the sort on</param>
    public static void TestArray(int testCase, int[] testArray)
    {
        Console.WriteLine("Test Case #" + testCase);
        Console.WriteLine("Array unsorted");
        PrintArray(testArray);
        MergeSort(testArray);
        Console.WriteLine("Array sorted:");
        PrintArray(testArray);
        Console.WriteLine("* * * * *\n");

    }

    /// <summary>
    /// Main method of the MergeSortTest. Runs a series of tests
    /// of the MergeSort method.
    /// </summary>
    /// <param name="args">command line arguments, not used</param>
    public static void Main(string[] args)
    {


        int[] testArray1 = { };
        int[] testArray2 = { 0, 1, 2, 3 };
        int[] testArray3 = { 0, 1, 2, 3, 4 };
        int[] testArray4 = { 3, 1, 4, 1, 5, 9, 2, 6, 5 };
        int[] testArray5 = { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 };


        TestArray(1, testArray1);
        TestArray(2, testArray2);
        TestArray(3, testArray3);
        TestArray(4, testArray4);
        TestArray(5, testArray5);


    }
}