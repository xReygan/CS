int[,] CreatRandomNaturalNumberMatrix(int m, int n)                 //Метод создания двумерного массива,
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
int[] FindIndexNumberMatrix(int[,] matrix, int findNumber)          //Метод поиска индекса искомого числа
{
    int[] array =new int[2];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (findNumber == matrix[i, j])
            {
                return array =new int[] {i,j};
            }
        }
    }
    return array =new int[] {-1,-1};;
}

Console.Write("Введите число строк m: ");                           //ввод данных
bool isNumberX1 = int.TryParse(Console.ReadLine(), out int m);
Console.Write("Введите число столбцов n: ");
bool isNumberX2 = int.TryParse(Console.ReadLine(), out int n);
Console.Write("Введите искомое число х: ");
bool isNumberX3 = int.TryParse(Console.ReadLine(), out int findNumber);
if (isNumberX1 != true || isNumberX2 != true || isNumberX3 != true)
{
    Console.WriteLine("Внимание!!! Некорректный ввод");
    return;
}
int[,] matrix = CreatRandomNaturalNumberMatrix(m, n);               //вызов Метода создания массива
Console.WriteLine("Задан массив:");
PrintMatrix(matrix);                                                //вызов Метода печати массива
int[] array = FindIndexNumberMatrix(matrix, findNumber);            //вызов Метода поиска индекса
if (array[0] == -1)
{
    Console.WriteLine($"Числа {findNumber} в заданном массиве нет.");
    return;
}
Console.WriteLine($"Число {findNumber} есть под индексом ({array[0]}, {array[1]})");   //вывод результата
