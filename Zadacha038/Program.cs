Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int [] array = new int [size];

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 100);
}
int max, min;
max = min = array[0];
for (int i = 0; i < array.Length; i++)
{
    if (max < array[i]) max = array[i];
    if (min > array[i]) min = array[i];
}
Console.WriteLine($"Выводим массив на экран $ {String.Join(", ", array)}");
Console.WriteLine($"Максимальное значение массива равно {max}; \nМинимальное значение массива равно {min}");
Console.WriteLine($"Разница между максимальным и минимальным значениями равна {max - min}");