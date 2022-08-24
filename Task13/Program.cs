int Razmer(int arg)                                        //Метод нахождения количества знаков в числе
{                                                          //Аргумент - число
    int i = arg;
    int n = 0;
    while (i > 0)
    {
        i = i / 10;
        n++;
    }
    int razmer = n;
    return razmer;
}
int Three(int arg, int razmer)                             //Метод нахождения 3-ей цифры в числе
{                                                          //Аргументы: число и количество цифр в числе
    int i;
    int digit = 0;
    for (i = 0; i < (razmer - 2); i++)
    {
        digit = arg % 10;
        arg = arg / 10;
    }
    return digit;
}
inter:
Console.Write("Введите число: ");                          //Ввод числа и его проверка на количества цифр
int number = Convert.ToInt32(Console.ReadLine());
int n=Razmer(number);
if (n < 3)
{
    Console.WriteLine("ВНИМАНИЕ!!! Третьей цифры НЕТ!!!");
    goto inter;
}
Console.WriteLine($"Третья цифра: {Three(number, n)}");    //Вывод 3-ей цифры числа
