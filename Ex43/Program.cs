Console.WriteLine($"Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int i = 0;
int digit = -1;
int result = number;
int[] array = new int[10];

while(result > 0)
{
digit = result % 2;
array[i] = digit;
result /= 2;
i++;
}

for(int ind = i; ind > 0; ind--)
{
while(array[i] != 1)
{
i--;
}
Console.Write(array[ind-1]);
}