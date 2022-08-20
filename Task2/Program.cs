Console.Write("Введите первое число ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число ");
int b = Convert.ToInt32(Console.ReadLine());
if (a>b) {Console.Write("Число "); Console.Write(a); Console.Write(" большее, ");Console.Write("Число "); Console.Write(b);Console.Write(" меньшее.");}
if (a<b) {Console.Write("Число "); Console.Write(b); Console.Write(" большее, ");Console.Write("Число "); Console.Write(a);Console.Write(" меньшее.");}
if (a==b) {Console.Write("Числа равны.");}