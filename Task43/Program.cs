double[] CrossingLine(double b1, double k1, double b2, double k2)    //Метод нахождения координат х,у точки
{                                                                    //пересечения двух прямых
    double[] resault = new double[3];
    resault[0] = -1;
    double tmp = k1 - k2;
    if (tmp == 0)
    {
        if (b1 == b2)
        {
            resault[0] = 0;
            return resault;                                          //прямые совпадают
        }
        resault[0] = 1;
        return resault;                                              //прямые параллельны
    }
    resault[1] = (b2 - b1) / tmp;
    resault[2] = (k1 * b2 - k2 * b1) / tmp;
    return resault;
}
void PrintPoint(double[] array)                                      //Метод печати результатов работы Метода
{                                                                    //нахождения координат точки пересечения
    if (array[0] == 0)                                               //двух прямых
    {
        Console.WriteLine("Прямые совпадают");
        return;
    }
    if (array[0] == 1)
    {
        Console.WriteLine("Прямые параллельны");
        return;
    }
    Console.WriteLine($"Координаты точки пересечения прямых: Х= {array[1]}  Y= {array[1]}");
    return;
}
Console.Write("Введите b1 первой прямой: ");
bool isNumberB1 = double.TryParse(Console.ReadLine(), out double b1);
Console.Write("Введите k1 первой прямой: ");
bool isNumberK1 = double.TryParse(Console.ReadLine(), out double k1);
Console.Write("Введите b2 второй прямой: ");
bool isNumberB2 = double.TryParse(Console.ReadLine(), out double b2);
Console.Write("Введите k2 второй прямой: ");
bool isNumberK2 = double.TryParse(Console.ReadLine(), out double k2);
if (isNumberB1 != true || isNumberK1 != true ||                      //проверка ввода данных
    isNumberB2 != true || isNumberK2 != true)
{
    Console.WriteLine("Внимание!!! Некорректный ввод");
    return;
}
double[] crosspoint = CrossingLine(b1, k1, b2, k2);                  //вызов Метода вычисления координат
PrintPoint(crosspoint);                                              //вызов Метода печати резльтата вычислений
