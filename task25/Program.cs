bool CheckInput(string inp, out int val)
{
    if (inp.ToUpper() == "Q") Environment.Exit(0);
    if (!int.TryParse(inp, out val)) return false;
    return true;
}

while (true)
{
    Console.Clear();
    Console.WriteLine("для выхода введите Q");
    Console.Write("Введите число для возведения в степень: ");
    string str = Console.ReadLine() ?? "";
    if (!CheckInput(str, out int num1)) continue;

    Console.Write("Введите степень: ");
    str = Console.ReadLine() ?? "";
    if (!CheckInput(str, out int num2)) continue;

    Console.WriteLine($"Число {num1} в степени {num2} равно: {Math.Pow(num1, num2)}");
    Console.WriteLine("Enter для продолжения...");
    Console.ReadLine();
}

