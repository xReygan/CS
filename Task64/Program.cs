//Задача 64: Задайте значения M и N. Напишите программу, которая выведет
//все натуральные числа в промежутке от M до N.

int[] MakingNatur(int m, int n, int[]array, int i)                   //Метод создания промежутка рекурсией
{
    if (m == n + 1)
    {
        return array;
    }
    array[i] = m;
    array = MakingNatur(m + 1, n, array, i+1);                       //вызов Метода внутри Метода
    return array;
}
void PrintArray(int[] array)                                         //Метод печати массива
{
    for (int i = 0; i < array.Length; i++)
        Console.Write($"{array[i]}  ");
}
Console.Write("Введите от m: ");                                     //ввод данных
bool isNumberX1 = int.TryParse(Console.ReadLine(), out int m);
Console.Write("Введите до n: ");
bool isNumberX2 = int.TryParse(Console.ReadLine(), out int n);
if (isNumberX1 != true || isNumberX2 != true)
{
    Console.WriteLine("Внимание!!! Некорректный ввод");
    return;
}
Console.WriteLine();
int[] array=new int[n-m+1];
array = MakingNatur(m, n, array, 0);                                 //вызов Метода промежутков
PrintArray(array);                                                   //вывод результата
