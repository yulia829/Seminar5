Console.Write("Введите количество элементов массива:" );
int a = Convert.ToInt32(Console.ReadLine());
int[] randomArray = new int[a];
mas(a);
void mas (int a)
{
    Console.Write("[ ");
    for (int i = 0; i < a; i++)
{
randomArray[i] = new Random().Next(99,999);
Console.Write(randomArray[i] + "  "  );

}
Console.Write("] ");
}

int count(int[] randomArray)
{
int count = 0;
for (int i = 0; i < randomArray.Length; i++)
{
if (randomArray[i] % 2 == 0)
count = count + 1;
}
return count;
}

Console.Write($"- Количество чётных чисел в массиве: {count(randomArray)}");
