Console.WriteLine($"Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int i = 0;
int digit = -1;
int result = number;
int[] binaryArray = new int[10];

while(result > 0)
{
digit = result % 2;
binaryArray[i] = digit;
result /= 2;
i++;
}

for(int index = i; index > 0; index--)
{
while(binaryArray[i] != 1)
{
i--;
}
Console.Write(binaryArray[index-1]);
}
