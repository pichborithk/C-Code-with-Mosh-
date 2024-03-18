using Methods;

int a = Calculator.Sum([1, 2, 3, 4, 5]);

int b = Calculator.Sum(1, 2, 3, 4, 5);

Calculator.IncreamentNoRef(a);

Calculator.Increament(ref b);

Console.WriteLine($"a = {a}");
Console.WriteLine($"b = {b}");
