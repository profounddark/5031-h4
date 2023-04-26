using System;

class MergeSort
{

    public static void Combine(int[] sortArray, int first, int middle, int last)
    {
        int[] tempArray = new int[last - first];

        int firstCount = first;
        int lastCount = middle + 1;
        int tempCount = 0;

        while ((firstCount <= middle) && (lastCount < last))
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

        int finalCount = (firstCount <= middle) ? firstCount : lastCount;
        for (; tempCount < tempArray.Length; tempCount++)
        {
            tempArray[tempCount] = sortArray[finalCount];
            finalCount++;
        }

        for (int i = 0; i < tempArray.Length; i++)
        {
            sortArray[i + first] = tempArray[i];
        }

    }

    public static void Sort(int[] sortArray, int first, int last)
    {
        if (first < last)
        {
            int middle = (first + last) / 2;
            Sort(sortArray, first, middle);
            Sort(sortArray, middle + 1, last);
            Combine(sortArray, first, middle, last);

        }
    }

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

    public static void TestArray(int[] testArray)
    {
        Console.WriteLine("Array unsorted");
        PrintArray(testArray);
        Sort(testArray, 0, testArray.Length);
        Console.WriteLine("Array sorted:");
        PrintArray(testArray);
        Console.WriteLine("* * * * *\n");

    }

    public static void Main(string[] args)
    {



        int[] testArray1 = { };
        int[] testArray2 = { 0, 1, 2, 3 };
        int[] testArray3 = { 0, 1, 2, 3, 4 };
        int[] testArray4 = { 3, 1, 4, 1, 5, 9, 2, 6, 5 };
        int[] testArray5 = { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 };


        TestArray(testArray1);
        TestArray(testArray2);
        TestArray(testArray3);
        TestArray(testArray4);
        TestArray(testArray5);


    }
}