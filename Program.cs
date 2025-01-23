internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello! This program will take 2 lists of numbers and combine them in number order from least to greatest");
        int[] array1 = collectArrays();
        int[] array2 = collectArrays();
    }

    public static int[] collectArrays()
    {
        int[] intArray = new int[4];
        bool validAnswer = false;
        int num;
        for(int i = 0; i < 4; i++)
        {
            do
            {
                Console.WriteLine("Please input a number larger than the previous");
                validAnswer = int.TryParse(Console.ReadLine(), out num);
                if(i > 0 && num > intArray[i-1])
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
}