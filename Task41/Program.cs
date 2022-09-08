bool InputValidation(string input)
{
    string[] inputArray = input.Split(",");
    int sizeArray = inputArray.Length;
    for (int i = 0; i < sizeArray; i++)
    {
        bool isNumber = int.TryParse(inputArray[i], out int tmp);
        if (isNumber != true)
        {
            Console.WriteLine("Внимание!!! Некорректный ввод");
            return false;
        }
    }
    return true;
}
int[] FillArray(string input)
{
    string[] inputArray = input.Split(",");
    int sizeArray = inputArray.Length;
    int[] array = new int[sizeArray];
    for (int i = 0; i < sizeArray; i++)
    {
        array[i] = Convert.ToInt32(inputArray[i]);
    }
    return array;
}
int HowManyNumbersGreaterZero(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    return count;
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}  ");
    }
    return;
}
Console.Write("Введите числа через запятую: ");
string input = Console.ReadLine();
if (InputValidation(input) == false)
{
    return;
}
int[] array = new int[1];
array = FillArray(input);
int howMany = HowManyNumbersGreaterZero(array);
Console.Write($"В массиве:  ");
PrintArray(array);
Console.WriteLine($"-->  {howMany} чисел(а) больше нуля.");
