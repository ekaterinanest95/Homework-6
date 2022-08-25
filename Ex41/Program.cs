int size = Convert.ToInt32(Console.ReadLine());
int[] arrayM = new int[size];
for(int i = 0; i < size; i++)
{
Console.WriteLine($"Введите {i} элемент массива: ");
arrayM[i] = Convert.ToInt32(Console.ReadLine());
}

int countPositiveDigits = 0;

for(int i = 0; i < size; i++)
{
if(arrayM[i] > 0) count += 1;
}

Console.Write($"{String.Join (", ", arrayM)} -> {countPositiveDigits}");
