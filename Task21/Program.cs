double FindDistance(int x1, int y1, int z1, int x2, int y2, int z2)      //Метод вычисления расстояния
{
    double distance = Math.Abs(Math.Sqrt(Math.Pow((x2 - x1), 2) +
                                         Math.Pow((y2 - y1), 2) +
                                         Math.Pow((z2 - z1), 2)));
    return distance;
}
Console.WriteLine("Введите координаты первой точки: ");                  //Ввод координат
Console.Write("Введите координату X1: ");
bool isNumberX1 = int.TryParse(Console.ReadLine(), out int x1);
Console.Write("Введите координату Y1: ");
bool isNumberY1 = int.TryParse(Console.ReadLine(), out int y1);
Console.Write("Введите координату Z1: ");
bool isNumberZ1 = int.TryParse(Console.ReadLine(), out int z1);
Console.WriteLine("Введите координаты второй точки: ");
Console.Write("Введите координату Х2: ");
bool isNumberX2 = int.TryParse(Console.ReadLine(), out int x2);
Console.Write("Введите координату Y2: ");
bool isNumberY2 = int.TryParse(Console.ReadLine(), out int y2);
Console.Write("Введите координату Z2: ");
bool isNumberZ2 = int.TryParse(Console.ReadLine(), out int z2);
if (isNumberX1 != true || isNumberY1 != true || isNumberZ1 != true ||    //Проверка корректности координат
    isNumberX2 != true || isNumberY2 != true || isNumberZ2 != true)
{
    Console.WriteLine("Внимание!!! Некорректный ввод");
    return;
}
Console.Write("Расстояние между точками равно: ");
Console.Write(FindDistance(x1, y1, z1, x2, y2, z2));                     //Вызов метода вычисления расстояния
