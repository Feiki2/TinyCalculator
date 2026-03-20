using System.Text;

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

Console.OutputEncoding = Encoding.UTF8;
Console.WriteLine($"{a} / {b} = {(double)a / b}");

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