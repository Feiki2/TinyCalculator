Console.WriteLine("== Tiny calculator ==");

Console.Write("1. Summand: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("2. Summand: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"{a} + {b} = {a + b}");