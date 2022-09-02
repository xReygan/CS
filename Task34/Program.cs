int[] MakingArray(int length)                                   //Метод создания массива заданной
{                                                               //длины случайными положительными 
    int[] array = new int[length];                              //трёхзначными числами
    Random random = new Random();
    for (int i = 0; i < length; i++)
    {
        array[i] = random.Next(100, 1000);
    }
    return array;
}
void PrintArray(int[] array)                                    //Метод вывода массива в консоль
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}  ");
    }
}
int CountingEvenNumbers(int[] array)                            //Метод вычисления количества четных чисел
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}
Console.WriteLine("Введите длину массива: ");
bool isNumber = int.TryParse(Console.ReadLine(), out int length);   //ввод длины массива
if (isNumber != true || length <= 0)                                //проверка ввода
{
    Console.WriteLine("Внимание!!! Некорректный ввод");
    return;
}
int[] given = MakingArray(length);                                  //Вызов метода создания массива
Console.Write("В массиве: ");
PrintArray(given);                                                  //Вызов метода печати массива
int even = CountingEvenNumbers(given);                              //Вызов метода вычисления четных чисел
Console.Write($" --> чётных чисел:  {even}");                       //Вывод результата