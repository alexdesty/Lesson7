namespace Lesson7task2;
internal class Program
{
    static void Main(string[] args)
    {
        var array = new int[3, 3]
        {
                { -4, 22, 3 },
                { 40, 22, 6 },
                { 11, -10, 330 }
        };
        for (var i = 0;i < array.GetLength(0);i++)
        {
            var maxElement = array[i, 0];

            for (var j = 0;j < array.GetLength(1);j++)
            {
                if (maxElement < array[i, j])
                {
                    maxElement = array[i, j];
                }
                Console.Write($"{array[i, j]}  ");
            }
            Console.WriteLine($"Max element: {maxElement}");
        }
    }
}
