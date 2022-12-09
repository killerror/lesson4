Console.Write("Введите число: ");
string str = Console.ReadLine() ?? "";

if (!int.TryParse(str, out int val)) return;

int sum = 0;
for (int i = 0; i < str.Length; i++)
    sum += int.Parse(str[i].ToString());

Console.Write($"Сумма цифр в числе {str} равна: {sum}");
