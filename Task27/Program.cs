int FindSumDigit(int arg)                                                   //Метод суммирования цифр в числе
{
    int i = arg;
    int sum=0;
    while (i > 0)
    {
        sum=sum+i%10;
        i = i / 10;
    }
    return sum;
}    
Console.Write("Введите число: ");                                           //ввод и проверка числа
bool isNumberX = int.TryParse(Console.ReadLine(), out int digit);
if (isNumberX != true || digit < 0)
{
    Console.WriteLine("Внимание!!! Некорректный ввод");
    return;
}
Console.Write($"Сумма всех цифр в числе: {FindSumDigit(digit)}");           //вызов метода сумирования цифр в числе
