Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int [] array = new int [size];
int sum = 0;
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 100);
    if (i%2 == 0) sum += array[i];
}
Console.WriteLine($"Массив случайных чисел: {String.Join(", ", array)} \n ");
Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях равна: {sum} ");
