/*
    List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
    List<int> numbers = new() { 1, 2, 3, 4, 5 };
    var numbers = new List<int>() { 1, 2, 3, 4, 5 };
*/

List<int> numbers = [1, 2, 3];
numbers.Add(4);


// numbers.AddRange(new int[3] { 5, 6, 7 });
numbers.AddRange([5, 6, 7]);
numbers.Remove(1);

Console.WriteLine(string.Join(", ", numbers));

Console.WriteLine("Index of 4: " + numbers.IndexOf(4));
