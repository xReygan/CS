int FindDegree(int a, int b)                                                //Метод возведения в степень a^b
{
    int result;
    if (b == 0)                                                             //проверка если b=0, то результат 1
    {
        return result = 1;
    }
    result = a;
    for (int i = 1; i < b; i++)
    {
        result = result * a;
    }
    return result;
}
Console.Write("Введите число основание степени: ");                         //ввод чисел
bool isNumberA = int.TryParse(Console.ReadLine(), out int a);
Console.Write("Введите число показатель степени: ");
bool isNumberB = int.TryParse(Console.ReadLine(), out int b);
if (isNumberA != true || isNumberB != true || b < 0 || (a == 0 && b == 0))
{
    Console.WriteLine("Внимание!!! Некорректный ввод");
    return;
}                                                                           //если b отрицательное: необходимо взять|b|, проделать весь алгоритм
Console.WriteLine($"{a}^{b} = {FindDegree(a, b)}");                         //и вычислить результат a^-b = 1/a^b 