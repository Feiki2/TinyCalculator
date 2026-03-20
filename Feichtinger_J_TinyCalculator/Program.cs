Console.WriteLine("== Tiny calculator ==");

Console.ForegroundColor = ConsoleColor.Green;

Console.Write("1. Operand: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("2. Operand: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.ResetColor();

Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine($"{a} + {b} = {a + b}");
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"{a} - {b} = {a - b}");
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine($"{a} * {b} = {a * b}");
Console.ResetColor();

if (b == 0)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"{a} / {b} = undefiniert/unendlich");
    Console.ResetColor();
}
else
{
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine($"{a} / {b} = {a / b}");
    Console.ResetColor();
}