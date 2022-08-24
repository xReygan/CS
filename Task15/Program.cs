string OutDay(int arg)                                     //Метод определения выходного и рабочего дней
{                                                          //Аргумент - число
    string outd;
    if (arg == 6 || arg == 7)
    {
        outd = "Выходной день";
        return outd;
    }
    outd = "Рабочий день";
    return outd;
}
inter:                                                     //Ввод числа
Console.Write("Введите число обозначающее день недели: "); 
int day = Convert.ToInt32(Console.ReadLine());
if (day < 1 || day > 7)
{
    Console.WriteLine("ВНИМАНИЕ!!! Некорректный ввод!!!");
    goto inter;
}

Console.WriteLine(OutDay(day));                            //Вывод выходного или рабочего дней
