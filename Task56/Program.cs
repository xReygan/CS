//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу,
//которая будет находить строку с наименьшей суммой элементов.

int[,] MakingMatrix(int line, int column)                  //Метод создания случайного массива
{
    int[,] array = new int[line, column];
    Random random = new Random();
    for (int i = 0; i < line; i++)
    {
        for (int j = 0; j < column; j++)
        {
            array[i, j] = random.Next(1, 10);
        }
    }
    return array;
}
void PrintArray(int[,] array)                              //Метод печати массива
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}  ");
        }
        Console.WriteLine();
    }
    return;
}
int SmallestString(int[,] array)                           //Метод поиска наименьшей суммы строки
{
    int minString = 0;
    int sumMin = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum = sum + array[i, j];
        }
        if (sum < sumMin || sumMin==0)
        {
            sumMin = sum;
            minString = i;
        }
    }
    return minString;
}
Console.Write("Введите количество строк m: ");                       //ввод данных
bool isNumberX1 = int.TryParse(Console.ReadLine(), out int line);
Console.Write("Введите количество столбцов n: ");
bool isNumberX2 = int.TryParse(Console.ReadLine(), out int column);
if (isNumberX1 != true || isNumberX2 != true)
{
    Console.WriteLine("Внимание!!! Некорректный ввод");
    return;
}
int[,] array = MakingMatrix(line, column);                           //вызов Метода создания массива
PrintArray(array);                                                   //печать исходного массива
Console.Write($"Наименьшая сумма элементов у {SmallestString(array)+1} строки");   //вывод результата
