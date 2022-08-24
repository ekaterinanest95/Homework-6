//y = k1 * x + b1, y = k2 * x + b2

Console.WriteLine($"Введите значение b1: ");
int b1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Введите значение k1: ");
int k1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Введите значение b2: ");
int b2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Введите значение k2: ");
int k2 = Convert.ToInt32(Console.ReadLine());

double delim = b2-b1;
double delit = k1-k2;

double line1 = delim / delit;
double line2 = k2 * line1 + b2;

Console.WriteLine();
Console.Write($"Координаты точки пересечения: ({line1}, {line2})");


