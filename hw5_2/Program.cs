Console.Write("Введите размер массива:");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
FillArrayRandomNumbers(numbers);

void FillArrayRandomNumbers(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = new Random().Next(-100,100);
             Console.Write(numbers[i] + " ");
        }
}
int sum = 0;
for (int i = 1; i < numbers.Length; i=i+2)
    sum = sum + numbers[i];
Console.Write("Сумма элементов:" +  sum);


