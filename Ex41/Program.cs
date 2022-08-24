int[] arrayM = new int[8];
for(int i = 0; i < arrayM.Length; i++)
{
Console.WriteLine($"Введите {i} элемент массива: ");
arrayM[i] = Convert.ToInt32(Console.ReadLine());
}

int count = 0;

for(int i = 0; i < arrayM.Length; i++)
{
if(arrayM[i] > 0) count += 1;
}

Console.Write($"{String.Join (", ", arrayM)} -> {count}");
