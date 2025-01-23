internal class Program
{
    private static void Main(string[] args)
    {

        Console.WriteLine("Hello! This program will take 2 lists of numbers and combine them in number order from least to greatest");
        Console.WriteLine("Please give the first list of numbers");
        int[] array1 = collectArrays();
        Console.WriteLine("Now give the second list of numbers");
        int[] array2 = collectArrays();
        foreach(int num  in mergeArrays(array1, array2))
        {
            Console.Write(num + " ");
        }
        System.Diagnostics.Debug.Assert(Enumerable.SequenceEqual)(
        mergeArrays(new int[]{1, 3, 5}, new int[]{-5, 3, 6, 7}),
        new int[]{-5, 1, 3, 3, 5, 6, 7});

    }

    public static int[] collectArrays()
    {
        Random rand = new Random();
        int arraySize = rand.Next(10);
        int[] intArray = new int[arraySize];
        bool validAnswer = false;
        int num;
        for(int i = 0; i < intArray.Length; i++)
        {
            do
            {
                Console.WriteLine("Please input a number larger than the previous");
                validAnswer = int.TryParse(Console.ReadLine(), out num);
                if(i > 0 && num < intArray[i-1])
                {
                    Console.WriteLine("Please make sure to give the numbers from smallest to largest");
                    validAnswer = false;
                }
            }
            while(!validAnswer);
            intArray[i] = num;
        }
        return intArray;
    }

    public static int[] mergeArrays(int[] a, int[] b)
    {
        int[] mergedList = new int[a.Length + b.Length];
        int aIndex = 0;
        int bIndex = 0;
        for(int i = 0; i < mergedList.Length; i++)
        {
            if(bIndex == b.Length || (a[aIndex] < b[bIndex] && aIndex != a.Length))
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
}
