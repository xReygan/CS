int[] MakingСube(int n)                                                  //Метод вычисления кубов заданных чисел
{
    int i;
    int[] cub = new int[n];
    for (i = 0; i < n; i++)
    {
        cub[i] = (int)Math.Pow((i + 1), 3);

    }
    return cub;
}
void PrintArray(int[] cub)                                               //Метод печати одномерного массива
{
    int i = 0;
    int len = cub.Length;
    for (i = 0; i < len; i++)
    {
        Console.Write($" {cub[i]}  ");
    }
}
Console.Write("Введите число (отрицательное число будет заменено положительным): ");
bool isNumber = int.TryParse(Console.ReadLine(), out int digit);         //Ввод числа
if (isNumber != true)                                                    //Проверка на число
{
    Console.WriteLine("Внимание!!! Некорректный ввод");
    return;
}
digit = Math.Abs(digit);                                                 //Модуль заданного числа
Console.WriteLine($"Исходное число: {digit} -->");
PrintArray(MakingСube(digit));                                           //Вызов метода печати для метода кубов
