int[,] CreatRandomIntegerNumberMatrix(int m, int n)                 //Метод создания двумерного массива,
{                                                                   //заполненного сучайными натуральными
    int[,] matrix = new int[m, n];                                  //числами
    Random random = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = (Convert.ToInt32(random.Next(0, 10)));
        }
    }
    return matrix;
}
void PrintMatrix(int[,] matrix)                                     //Метод печати двумерного массива
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($" {matrix[i, j]}  ");
        }
        Console.WriteLine();
    }
}
double[] MeanArithmeticColumnMatrix(int[,] matrix)          //Метод поиска индекса искомого числа
{
    double[] array = new double[matrix.GetLength(1)];
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            array[j] = array[j] + matrix[i, j];
        }
        array[j] = Math.Round(array[j] / matrix.GetLength(0), 1);
    }
    return array;
}

Console.Write("Введите число строк m: ");                           //ввод данных
bool isNumberX1 = int.TryParse(Console.ReadLine(), out int m);
Console.Write("Введите число столбцов n: ");
bool isNumberX2 = int.TryParse(Console.ReadLine(), out int n);
if (isNumberX1 != true || isNumberX2 != true)
{
    Console.WriteLine("Внимание!!! Некорректный ввод");
    return;
}
int[,] matrix = CreatRandomIntegerNumberMatrix(m, n);               //вызов Метода создания массива
Console.WriteLine("Задан массив:");
PrintMatrix(matrix);                                                //вызов Метода печати массива
double[] array = MeanArithmeticColumnMatrix(matrix);
Console.Write($"Среднее арифметическое каждого столбца: ");           //вызов Метода поиска индекса
for (int i = 0; i < array.Length; i++)
{
    Console.Write($"{array[i]}  ");
}
//вывод результата
