int i;
Console.Write("Введите число ");
int n = Convert.ToInt32(Console.ReadLine());
if (n<0) {Console.Write(n); Console.Write(" вы ввели отрицательное число.");}
if (n==0) {Console.Write(n); Console.Write(" вы ввели ноль.");}
for (i=1; i<=n; i++)
{
if (i%2==0) {Console.Write(i); Console.Write(" ");} 
}
