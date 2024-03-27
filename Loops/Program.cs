int[] numbers = [1, 2, 3, 4, 5];

// foreach Loop
foreach (var n in numbers)
{
    Console.WriteLine(n);
}

// While Loop
int i = 0;
while (i < 5)
{
    Console.WriteLine("While loop iteration: " + i);
    i++;
}

// For Loop
for (int j = 0; j < 5; j++)
{
    Console.WriteLine("For loop iteration: " + j);
}

// Do-While Loop
int k = 0;
do
{
    Console.WriteLine("Do-While loop iteration: " + k);
    k++;
} while (k < 5);

// Break and Continue Statements
for (int l = 0; l < 10; l++)
{
    if (l == 5)
    {
        break; // Exit the loop when l equals 5
    }
    if (l % 2 == 0)
    {
        continue; // Skip the current iteration if l is even
    }
    Console.WriteLine("Value of l: " + l);
}

// Pause the program to view the output
Console.ReadLine();