// Напишите программу, которая заполнит спирально массив 4 на 4.

int[,] MakingSpiralMatrix(int line)                                  //Метод создания спирального массива
{
    int[,] array = new int[line, line];                              //инициализация начальных переменных
    int mean = 0;
    int first = 0;
    int i = 0;
    int j = 0;
    int last = line;
    int maxim = array.Length;
    if (line % 2 != 0)                                               //дополнительное действие для 
    {                                                                //нечетной длины стороны массива
        array[line / 2, line / 2] = line * line;
    }
    while (mean <= (maxim+line))
    {
        for (j = first; j < last; j++)
        {
            mean = mean + 1;
            array[i, j] = mean;
        }
        j = j - 1;
        for (i = first + 1; i < last; i++)
        {
            mean = mean + 1;
            array[i, j] = mean;
        }
        i = i - 1;
        for (j = last - 2; j >= first; j--)
        {
            mean = mean + 1;
            array[i, j] = mean;
        }
        j = j + 1;
        for (i = last - 2; i >= first + 1; i--)
        {
            mean = mean + 1;
            array[i, j] = mean;
        }
        last = last - 1;
        first = first + 1;
        i = first;
        maxim = maxim - 1;
    }
    return array;
}
void PrintArray(int[,] array)                                        //Метод печати массива
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
Console.Write("Введите количество строк i: ");                       //ввод данных
bool isNumberX = int.TryParse(Console.ReadLine(), out int line);
if (isNumberX != true)
{
    Console.WriteLine("Внимание!!! Некорректный ввод");
    return;
}
int[,] array = MakingSpiralMatrix(line);                             //вызод Метода создания массива
Console.WriteLine("Исходная матрица: ");
PrintArray(array);                                                   //вывод результата
