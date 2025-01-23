using System.Runtime.CompilerServices;
/**********************************
* Name: Caleb Roskelley
* CS 1415 Lab 2 MergeSort
* Professor Lewellan
* Due Date: 01/22/2025
**********************************/


internal class Program
{
    private static void Main(string[] args)
    {

        Console.WriteLine("Hello! This program will take 2 lists of numbers and combine them in number order from least to greatest");
        //test 1
        System.Diagnostics.Debug.Assert(Enumerable.SequenceEqual(
        mergeArrays(new int[]{1, 3, 5}, new int[]{-5, 3, 6, 7}),
        new int[]{-5, 1, 3, 3, 5, 6, 7}));

        //test 2
        System.Diagnostics.Debug.Assert(Enumerable.SequenceEqual(
        mergeArrays(new int[]{-5, 2, 5, 8, 10}, new int[]{1, 2, 5}),
        new int[]{-5, 1, 2, 2, 5, 5, 8, 10}));

        // //test 3
        System.Diagnostics.Debug.Assert(Enumerable.SequenceEqual(
        recursiveMergedArrays(new int[]{6, 1, -5, 3, 5, 3, 7}),
        new int[]{-5, 1, 3, 3, 5, 6, 7}));
        //test 4
        System.Diagnostics.Debug.Assert(Enumerable.SequenceEqual(
        recursiveMergedArrays(new int[]{1, 10, -5, 2, 5, 2, 5, 8}),
        new int[]{-5, 1, 2, 2, 5, 5, 8, 10}));

        Console.WriteLine("Passed all four tests");
    }

    public static int[] mergeArrays(int[] a, int[] b)
    {
        int[] mergedList = new int[a.Length + b.Length];
        int aIndex = 0;
        int bIndex = 0;
        for(int i = 0; i < mergedList.Length; i++)
        {

            if(bIndex == b.Length || ( aIndex < a.Length && a[aIndex] < b[bIndex]))
            {
                mergedList[i] = a[aIndex];
                aIndex++;
            }
            else
            {
                mergedList[i] = b[bIndex];
                bIndex++;
            }
        }
        return mergedList;
    }

    public static int[] recursiveMergedArrays(int[] values)
    {
        int middle = values.Length / 2;
        int[] firstHalf = new int[middle];
        int[] secondHalf = new int[values.Length - middle];

        for(int i = 0; i < values.Length - middle; i++)
        {
            if(i < middle)
            {

                firstHalf[i] = values[i];
            }
            secondHalf[i] = values[i + middle];
        }

        if(values.Length < 2)
        {
            return values;
        }
        else
        {
            return mergeArrays(recursiveMergedArrays(firstHalf), recursiveMergedArrays(secondHalf));
        }
        
    }
}
