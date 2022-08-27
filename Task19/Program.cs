int FineSize(int arg)                                         //Метод определения значности числа
{
    int i = arg;
    int n = 0;
    while (i > 0)
    {
        i = i / 10;
        n++;
    }
    int size = n;
    return size;
}
int FinePalindrome(int x, int n)                              //Метод из числа создает массив
{                                                             //и определяет палиндромность
    int[] line = new int[n];
    int variable = x;
    int i;
    for (i = n - 1; i >= 0; i--)
    {
        line[i] = variable % 10;
        variable = variable / 10;
    }
    for (i = 0; i < n - i - 1; i++)
    {
        bool pal = (line[i] == line[n - i - 1]);
        if (pal != true)
        {
            return 0;                                         //Возвращает 0, если не палиндром
        }
    }
    return 1;                                                 //Возвращает 1, если палиндром
}
Console.WriteLine("Введите пятизначное число: ");
bool isNumber = int.TryParse(Console.ReadLine(), out int digit);
if (isNumber != true || digit < 10000 || digit > 100000)      //Проверка на пятизначное число
{
    Console.WriteLine("Внимание!!! Некорректный ввод");
    return;
}
int size = FineSize(digit);
if (FinePalindrome(digit, size) == 0)
{
    Console.WriteLine("Число не палиндром.");
    return;
};
Console.WriteLine("Число палиндром.");
