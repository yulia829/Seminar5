Console.Write("Введите количество элементов массива: ");
int a = Convert.ToInt32(Console.ReadLine());
double[] randomArray = new double[a];
mas(a);
void mas(int a)
{
Random rand = new Random();
Console.Write("[ ");
for (int i = 0; i < a; i++)

{
randomArray[i] = rand.NextDouble();
Console.Write($"{randomArray[i]} ");
}
Console.Write("] ");
}

double raz(double[] randomArray)
{
double min = randomArray[0];
double max = randomArray[0];
int i = 1;
while (i < randomArray.Length)
{
if (max<randomArray[i])
max = randomArray[i];
if (min>randomArray[i])
min = randomArray[i];
i = i + 1;
}
Console.WriteLine($"Минимальное число: {min}");
Console.WriteLine($"Максимальное число: {max}");
return max-min;
}

Console.Write($"Разница между максимальным и минимальным элементов массива: {raz(randomArray)}");