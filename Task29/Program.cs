int[] SetArrayFromString(string imput)                                      //Метод создания массива из строчной записи чисел, разделенных запятой
{                                                                           //можно использовать пробелы до и после запятой
    int n = imput.Length;                                                   //длина сторки
    int size = 1;
    for (int i = 0; i < n; i++)                                             //цикл нахождения количества чисел в записи
    {
        if (imput[i] == ',')
        {
            size++;
        }
    }
    int[] array = new int[size];
    int m = 0;
    string result = String.Empty;
    for (int i = 0; i < n; i++)                                             //цикл сканирования записи для нахождения чисел и записи их в массив
    {
        if (imput[i] != ',')
        {
            result = result + imput[i];
        }
        if (imput[i] == ',')
        {
            array[m] = Convert.ToInt32(result);
            result = String.Empty;
            m++;
        }
    }
    array[m] = Convert.ToInt32(result);
    return array;
}
void PrintArray(int[] matrix)                                               //Метод печати одномерного массива
{
    int i = 0;
    int len = matrix.Length;
    for (i = 0; i < len; i++)
    {
        Console.Write($" {matrix[i]}   ");
    }
}
Console.WriteLine("Введите массив чисел через запятую: ");                  //Ввод массива чисел - целые полжительные или отрицательные
string digit = Console.ReadLine();                                          //можно использовать пробелы до и после запятой
int n = digit.Length;
for (int i = 0; i < n; i++)
{
    if (digit[i] != '0' && digit[i] != '1' && digit[i] != '2' && digit[i] != '3' &&   //Проверка на числа, запятую, пробел и минус
        digit[i] != '4' && digit[i] != '5' && digit[i] != '6' && digit[i] != '7' &&
        digit[i] != '8' && digit[i] != '9' && digit[i] != ',' && digit[i] != '-' &&
        digit[i] != ' ')
    {
        Console.WriteLine("Внимание!!! Некорректный ввод");
        return;
    }
}
int[] array = SetArrayFromString(digit);                                     //Вызов метода преобразования строки чисел в массив
int count = array.Length;
Console.WriteLine($"Задан массив из {count} элементa(ов):");
PrintArray(array);                                                          //Вызов метода печати одномерного массива
