namespace Lesson7;
internal class Program
{
    static void Main(string[] args)
    {
        var array = new int[6];
        for (int i = 0;i < array.Length;i++)
        {
            {
                Console.Write($"Enter {i} array element: ");
                while (!int.TryParse(Console.ReadLine(), out array[i]))
                {
                    Console.Write($"Incorrect data. Enter {i} array element: ");
                }
            }
        }
        Array.Sort(array);
        Array.Reverse(array);
        Console.Write($"Sorted array in descending order: ");
        foreach (var index in array)
        {
            Console.Write($"{index} ");
        }
    }
}
