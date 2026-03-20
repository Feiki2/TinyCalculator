Console.WriteLine("== Tiny calculator ==");

Console.ForegroundColor = ConsoleColor.Green;

int a = OperandError("1. Operand: ");

int b = OperandError("2. Operand: ");

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

static int OperandError(string title)
{
        Console.Write($"{title} ");
        int a;
        while (!int.TryParse(Console.ReadLine(), out a))
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"FEHLER: {title }ist keine Zahl!");
            Console.ResetColor();
            Console.Write($"{title} ");
        }
        return a;
}