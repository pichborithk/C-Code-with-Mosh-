Console.WriteLine("C# have 4 Integral Numbers type:");
Console.WriteLine("Integer is the DEFUALT type for Integral Numbers\n");

byte byteMin = byte.MinValue;
byte byteMax = byte.MaxValue;
Console.WriteLine("Byte = 1 byte, has value range from {0} to {1}", byteMin, byteMax);

short shortMin = short.MinValue;
short shortMax = short.MaxValue;
Console.WriteLine($"Short = 2 bytes, has value range: {shortMin} to {shortMax}");

int integerMin = int.MinValue;
int integerMax = int.MaxValue;
Console.WriteLine($"Integer = 4 bytes, has value range: {integerMin} to {integerMax}");


long longMin = long.MinValue;
long longMax = long.MaxValue;
Console.WriteLine($"Long = 8 bytes, has value range: {longMin} to {longMax}\n");

Console.WriteLine("C# have 3 Real Numbers type:");
Console.WriteLine("Double is the DEFUALT type for Real Numbers\n");

float floatMin = float.MinValue;
float floatMax = float.MaxValue;
Console.WriteLine($"Float = 4 bytes, has value range: {floatMin} to {floatMax}");
float Pi = 3.14f;
Console.WriteLine($"This is how to declare float Pi = {Pi}f");

double doubleMin = double.MinValue;
double doubleMax = double.MaxValue;
Console.WriteLine($"Double = 8 bytes, has value range: {doubleMin} to {doubleMax}");


decimal decimalMin = decimal.MinValue;
decimal decimalMax = decimal.MaxValue;
Console.WriteLine("Decimal = 16 bytes, has value range: {0} to {1}", decimalMin, decimalMax);
decimal myDecimal = 1.01m;
Console.WriteLine($"This is how to declare decimal myDecimal = {myDecimal}m\n");

Console.WriteLine("Character type (2 bytes)\n");
char a = 'a';
Console.WriteLine($"Variable a = {a} is Character type\n");

Console.WriteLine("Boolean type (1 bytes)\n");
bool isTrue = true;
Console.WriteLine($"Variable isTrue = {isTrue} is Boolean Type");