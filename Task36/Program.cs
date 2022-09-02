int[] MakingArray(int length)                                       //Метод создания массива заданной
{                                                                   //длины случайными двухзначными
    int[] array = new int[length];                                  // числами
    Random random = new Random();
    for (int i = 0; i < length; i++)
    {
        array[i] = random.Next(-99, 100);
    }
    return array;
}
void PrintArray(int[] array)                                        //Метод вывода массива в консоль
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}  ");
    }
}
int SumOddIndices(int[] array)                                      //Метод вычисления суммы элементов,
{                                                                   //стоящих на нечетных позициях
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0)
        {
            sum = sum + array[i];
        }
    }
    return sum;
}
Console.WriteLine("Введите длину массива: ");
bool isNumber = int.TryParse(Console.ReadLine(), out int length);    //ввод длины массива
if (isNumber != true || length <= 1)                                 //проверка ввода
{
    Console.WriteLine("Внимание!!! Некорректный ввод");
    return;
}
int[] odd = MakingArray(length);                                     //Вызов метода создания массива
Console.Write($"В массиве: ");
PrintArray(odd);                                                     //Вызов метода печати массива
int sum = SumOddIndices(odd);                                        //Вызов метода вычисления четных чисел
Console.Write($" --> сумма элементов стоящих на нечетных позициях =:  {sum}");       //Вывод результата