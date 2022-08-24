inter:
Console.Write("Введите положительное трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int i = number;                                   //Начало проверки числа на количество знаков
int n = 0;
while (i > 0)
{
    i = i / 10;
    n++;
}                                                 //В переменной n накапливается количество знаков числа
if (n != 3)
{
    Console.WriteLine("ВНИМАНИЕ!!! Вы ввели некорректное число!!!");
    goto inter;
}
int digit = number / 10 % 10;                     //Нахождение 2-го знака введенного числа
Console.WriteLine($"Вторая цифра: {digit}");
