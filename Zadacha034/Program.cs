Console.WriteLine("Введите размер массива");

int size = Convert.ToInt32(Console.ReadLine());

int [] array = new int [size];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(100, 1000);
}
Console.Write($"Массив: {String.Join(", ", array)} \n");
int counter = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i]%2 == 0)
    {
        counter ++;
    }
}
Console.WriteLine($"Количество чётных элементов в массиве равно: {counter}");
