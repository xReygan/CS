int[] MakingArray(int length)                                      //Метод создания массива заданной длины
{                                                                  //случайными двухзначными числами
    int[] array = new int[length];                                 
    Random random = new Random();
    for (int i = 0; i < length; i++)
    {
        array[i] = random.Next(-99, 100);
    }
    return array;
}
void PrintArray(int[] array)                                       //Метод вывода массива в консоль
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}  ");
    }
}
int FindDifferenceMaxMin(int[] array)                              //Метод нахождения разницы между максимальным 
{                                                                  //и минимальным элементами массива
    int min = array[0];
    int max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (min > array[i])
        {
            min = array[i];
        }
        if (max < array[i])
        {
            max = array[i];
        }
    }
    return (max-min);
}
Console.WriteLine("Введите длину массива: ");
bool isNumber = int.TryParse(Console.ReadLine(), out int length);    //ввод длины массива
if (isNumber != true || length <= 1)                                 //проверка ввода
{
    Console.WriteLine("Внимание!!! Некорректный ввод");
    return;
}
int[] matrix = MakingArray(length);                                  //Вызов метода создания массива
Console.Write($"В массиве: ");
PrintArray(matrix);                                                  //Вызов метода печати массива
int diff = FindDifferenceMaxMin(matrix);                             //Вызов метода вычисления разницы
Console.Write($" --> разница между max и min =:  {diff}");           //Вывод результата
