//Напишите программу вычисления функции Аккермана с помощью рекурсии.
//Даны два неотрицательных числа m и n.

int Akkerman(int m, int n, int rez)                                  //Метод функции Аккермана рекурсией
{
    if (m == 0)
    {
        rez = n + 1;
        return rez;
    }
    if (m > 0 && n == 0)
    {
        rez = Akkerman(m - 1, 1, rez);                               //вызов рекурсии в рекурсии
        return rez;
    }
        rez = Akkerman(m - 1, Akkerman(m, n - 1, rez), rez);         //вызов рекурсии в рекурсии в рекурсии
        return rez;
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
int rez = Akkerman(m, n, 0);                                         //вызов Метода функции Аккермана
Console.Write(rez);                                                  //вывод результата
