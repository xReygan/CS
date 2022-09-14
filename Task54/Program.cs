//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит  
//по убыванию элементы каждой строки двумерного массива.

int[,] MakingMatrix(int line, int column)                  //Метод создания случайного массива
{
    int[,] array = new int[line, column];
    Random random = new Random();
    for (int i = 0; i < line; i++)
    {
        for (int j = 0; j < column; j++)
        {
            array[i, j] = random.Next(10, 100);
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
void SortingInRows(int[,] array)                           //Метод упорядочивания массива по строкам
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            int b = j;
            for (int t = j; t < array.GetLength(1); t++)
            {
                if (array[i, b] < array[i, t])
                {
                    b = t;
                }
            }
            int tmp = array[i, j];
            array[i, j] = array[i, b];
            array[i, b] = tmp;
        }
    }
    return;
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
Console.WriteLine("Исходный массив:");
PrintArray(array);                                                   //печать исходного массива
SortingInRows(array);                                                //вызов Метода сортировки
Console.WriteLine("Отсортированный массив:");
PrintArray(array);                                                   //печать отсортированного массива
