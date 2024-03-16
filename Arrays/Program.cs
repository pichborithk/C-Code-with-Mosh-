/*
    int[] numbers = new int[5] {1, 2, 3, 4, 5};
    var numbers = new[] {1, 2, 3, 4, 5};
*/

int[] numbers = [1, 2, 3, 4, 5];

Console.WriteLine(string.Join(", ", numbers));

Console.WriteLine("Index of 4: " + Array.IndexOf(numbers, 4));

Array.Clear(numbers, 0, 2);

Console.WriteLine("After Clear from index 0 to 2: " + string.Join(", ", numbers));

Array.Reverse(numbers);

Console.WriteLine("After Reverse: " + string.Join(", ", numbers));

var matrix = new int[3, 4]
{
    {1, 2, 3, 4},
    {1, 2, 3, 4},
    {1, 2, 3, 4},
};

Console.WriteLine($"Length of matrix array is : {matrix.Length}");

foreach (var n in matrix)
{
    Console.Write(n + " ");
}

Console.WriteLine();

