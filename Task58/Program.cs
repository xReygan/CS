//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int[,] MakingMatrix(int line, int column)                           //Метод создания произвольной матрицы
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
void PrintArray(int[,] array)                                       //Метод печати матрицы
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

int[,] MultiplicationMatrix(int[,] array1, int[,] array2)           //Метод умножения двух матриц
{
    int tmp = 0;
    if (array1.GetLength(0) < array2.GetLength(1))
    {
        tmp = array2.GetLength(1);
    }
    tmp = array2.GetLength(0);
    int[,] multiplicat = new int[array1.GetLength(0), array2.GetLength(1)];
    for (int i = 0; i < multiplicat.GetLength(0); i++)
    {
        for (int j = 0; j < multiplicat.GetLength(1); j++)
        {
            for (int z = 0; z < tmp; z++)
            {
                multiplicat[i, j] = multiplicat[i, j] + array1[i, z] * array2[z, j];
            }

        }

    }
    return multiplicat;
}
Console.Write("Введите количество строк l: ");                       //ввод данных
bool isNumberX1 = int.TryParse(Console.ReadLine(), out int line1);
Console.Write("Введите количество столбцов m: ");
bool isNumberX2 = int.TryParse(Console.ReadLine(), out int column1);
Console.Write("Введите количество строк m: ");
bool isNumberX3 = int.TryParse(Console.ReadLine(), out int line2);
Console.Write("Введите количество столбцов n: ");
bool isNumberX4 = int.TryParse(Console.ReadLine(), out int column2);
if (isNumberX1 != true || isNumberX2 != true ||
    isNumberX1 != true || isNumberX2 != true)
{
    Console.WriteLine("Внимание!!! Некорректный ввод");
    return;
}
if (column1 != line2)
{
    Console.WriteLine("Внимание!!! Произведение данных матриц невозможно");
    return;
}

// int[,] array1 = {{2,4},{3,2}};                          //две матрицы из условия задачи
// int[,] array2 = {{3,4},{3,3}};                          //для опытов

int[,] array1 = MakingMatrix(line1, column1);              //вызов Метода создания 1-ой матрицы
PrintArray(array1);                                        //и ее вывод на экран
Console.WriteLine("*******");
int[,] array2 = MakingMatrix(line2, column2);              //вызов Метода создания 2-ой матрицы
PrintArray(array2);                                        //и ее вывод на экран
Console.WriteLine("=======");
int[,] resualt = MultiplicationMatrix(array1, array2);     //вызов Метода умножения матриц
PrintArray(resualt);                                       //печать результата
