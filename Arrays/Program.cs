// Single-Dimensional Array
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

// Multi-Dimensional Array

// int[,] matrix = new int[3, 4];
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

Console.WriteLine(matrix[0, 0]);

// Jagged Array (Array of Arrays)
int[][] jaggedArray = new int[3][]; // Declare a jagged array of size 3

// Initialize each sub-array with different sizes
jaggedArray[0] = new int[2] { 1, 2 };
jaggedArray[1] = new int[3] { 3, 4, 5 };
jaggedArray[2] = new int[4] { 6, 7, 8, 9 };

// Access and print values from the jagged array using nested for loops
Console.WriteLine("\nJagged Array:");
for (int i = 0; i < jaggedArray.Length; i++)
{
    for (int j = 0; j < jaggedArray[i].Length; j++)
    {
        Console.Write(jaggedArray[i][j] + " ");
    }
    Console.WriteLine();
}

// Pause the program to view the output
Console.ReadLine();