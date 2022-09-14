//Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.  
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

int[,,] MakingNonRepeatingMatrix(int line, int column, int depth)    //Метод создания 3-ех мерного массива
{
    int[,,] array = new int[line, column, depth];
    Random random = new Random();
    for (int i = 0; i < line; i++)
    {
        for (int j = 0; j < column; j++)
        {
            for (int k = 0; k < depth; k++)
            {
                int t = random.Next(10, 100);
                while (RepeatabilityTest(array, t) == false)         //вызов Метода проверки числа
                {
                    t = random.Next(10, 100);
                }
                array[i, j, k] = t;
            }
        }
    }
    return array;
}
bool RepeatabilityTest(int[,,] array, int x)                         //Метод проверки совпадающих чисел 
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                if (array[i, j, k] == x)
                {
                    return false;
                }
            }
        }
    }
    return true;
}
void PrintThreeArray(int[,,] array)                                  //Метод печати 3-уч мерного массива
{
    for (int k = 0; k < array.GetLength(2); k++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write($"{array[i, j, k]}({i},{j},{k})  ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
    return;
}
Console.Write("Введите количество строк i: ");                       //ввод дванных
bool isNumberX1 = int.TryParse(Console.ReadLine(), out int line);
Console.Write("Введите количество столбцов j: ");
bool isNumberX2 = int.TryParse(Console.ReadLine(), out int column);
Console.Write("Введите глубину k: ");
bool isNumberX3 = int.TryParse(Console.ReadLine(), out int depth);
if (isNumberX1 != true || isNumberX2 != true || isNumberX3 != true)
{
    Console.WriteLine("Внимание!!! Некорректный ввод");
    return;
}
if (line * column * depth > 90)
{
    Console.WriteLine("Внимание!!! Слишком большая матрица");
    return;
}
int[,,] array = MakingNonRepeatingMatrix(line, column, depth);       //вызов Метода создания массива
Console.WriteLine("Исходная матрица: ");
PrintThreeArray(array);                                              //вызов Метода печати массива
