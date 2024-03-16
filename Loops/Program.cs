int[] numbers = [1, 2, 3, 4, 5];

for (int i = 0; i < numbers.Length; i++)
{
    Console.WriteLine(numbers[i]);
}

foreach (var n in numbers)
{
    Console.WriteLine(n);
}

int j = 0;
while (j < numbers.Length)
{
    Console.WriteLine(numbers[j]);
    j++;
}

int k = 0;
do
{
    Console.WriteLine(numbers[k]);
    k++;
} while (k < numbers.Length);