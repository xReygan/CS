//Задайте значения M и N. Напишите программу, которая найдёт
//сумму натуральных элементов в промежутке от M до N.

int SumNatur(int m, int n, int sum)                                //Метод поиска суммы промежутка рекурсией
{
    if (m == n + 1)
    {
        return sum;
    }
    sum = sum + m;
    sum = SumNatur(m + 1, n, sum);                                 //вызов Метода внутри Метода
    return sum;
}
Console.Write("Введите от m: ");                                   //ввод данных
bool isNumberX1 = int.TryParse(Console.ReadLine(), out int m);
Console.Write("Введите до n: ");
bool isNumberX2 = int.TryParse(Console.ReadLine(), out int n);
if (isNumberX1 != true || isNumberX2 != true)
{
    Console.WriteLine("Внимание!!! Некорректный ввод");
    return;
}
Console.WriteLine();
int sum;
sum = SumNatur(m, n, 0);                                           //вызов Метода суммы
Console.Write(sum);                                                //вывод результата
