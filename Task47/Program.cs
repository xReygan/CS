double[,] CreatRandomRealNumberMatrix(int m, int n)                 //Метод создания двумерного массива,
{                                                                   //заполненного сучайными вещественными
    double[,] matrix = new double[m, n];                            //числами
    Random random = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = (Convert.ToDouble(random.Next(-100, 100))) / 10;
        }
    }
    return matrix;
}
void PrintMatrix(double[,] matrix)                                  //Метод печати двумерного массива
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"    {matrix[i, j]}  ");
        }
        Console.WriteLine();
    }
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
double[,] array = CreatRandomRealNumberMatrix(m, n);                //вызов Метода создания массива
Console.WriteLine();
PrintMatrix(array);                                                 //вызов Метода печати массива
