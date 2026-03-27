using System.Text;

Console.OutputEncoding = Encoding.UTF8;
Console.WriteLine("== Tiny calculator ==");

Console.ForegroundColor = ConsoleColor.Green;
double current = ReadNumber("1. Operand:");
double second = ReadNumber("2. Operand:");
Console.ResetColor();

PrintResults(current, second);

while (true)
{
    Console.WriteLine();
    Console.Write("Wähle Ergebnis zum Weiterrechnen (1:+  2:-  3:*  4:/), 'n' = neue Operanden, 'q' = beenden: ");
    var choice = Console.ReadLine()?.Trim().ToLowerInvariant();

    if (string.IsNullOrEmpty(choice))
        continue;

    if (choice == "q")
        break;

    if (choice == "n")
    {
        Console.ForegroundColor = ConsoleColor.Green;
        current = ReadNumber("1. Operand:");
        second = ReadNumber("2. Operand:");
        Console.ResetColor();
        PrintResults(current, second);
        continue;
    }

    if (choice is "1" or "2" or "3" or "4")
    {
        double result;
        switch (choice)
        {
            case "1":
                result = current + second;
                break;
            case "2":
                result = current - second;
                break;
            case "3":
                result = current * second;
                break;
            case "4":
                if (second == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("FEHLER: Division durch 0 ist nicht erlaubt. Bitte neuen zweiten Operanden eingeben.");
                    Console.ResetColor();
                    second = ReadNumber("Neuer 2. Operand:");
                    continue;
                }
                result = current / second;
                break;
            default:
                continue;
        }

        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine($"Ausgewähltes Ergebnis: {result}");
        Console.ResetColor();

        // Weiterrechnen: Ergebnis wird zum ersten Operand, Nutzer gibt neuen zweiten Operand
        current = result;
        second = ReadNumber("Neuer 2. Operand:");
        PrintResults(current, second);
        continue;
    }

    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Ungültige Auswahl. Bitte 1,2,3,4, n oder q eingeben.");
    Console.ResetColor();
}

static double ReadNumber(string prompt)
{
    Console.Write($"{prompt} ");
    double value;
    while (!double.TryParse(Console.ReadLine(), out value))
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"FEHLER: '{prompt}' ist keine Zahl!");
        Console.ResetColor();
        Console.Write($"{prompt} ");
    }
    return value;
}

static void PrintResults(double a, double b)
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine($"{a} + {b} = {a + b}");
    Console.ResetColor();

    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"{a} - {b} = {a - b}");
    Console.ResetColor();

    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.WriteLine($"{a} * {b} = {a * b}");
    Console.ResetColor();

    Console.ForegroundColor = ConsoleColor.White;
    if (b == 0)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"{a} / {b} = FEHLER (Division durch 0)");
    }
    else
    {
        Console.ResetColor();
        Console.WriteLine($"{a} / {b} = {(double)a / b}");
    }
    Console.ResetColor();
}