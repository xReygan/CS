int FindSumDigit(int arg)
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
Console.Write("Введите число: ");
bool isNumberX = int.TryParse(Console.ReadLine(), out int digit);
if (isNumberX != true || digit < 0)
{
    Console.WriteLine("Внимание!!! Некорректный ввод");
    return;
}
Console.Write($"Сумма всех цифр в числе: {FindSumDigit(digit)}");
