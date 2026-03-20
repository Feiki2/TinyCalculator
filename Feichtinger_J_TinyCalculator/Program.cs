Console.WriteLine("== Tiny calculator ==");

Console.Write("1. Operand: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("2. Operand: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"{a} + {b} = {a + b}");
Console.WriteLine($"{a} - {b} = {a - b}");
Console.WriteLine($"{a} * {b} = {a * b}");
Console.WriteLine($"{a} / {b} = {a / b}");

if (b == 0)
{
    Console.WriteLine($"{a} / {b} = undefiniert/unendlich");
}
else
{
    Console.WriteLine($"{a} / {b} = {a / b}");
}