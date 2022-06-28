// Решение задачи №6

int a;

Console.WriteLine("Введите число a");
a = Convert.ToInt32(Console.ReadLine());

if (a%2==0)
{
    Console.WriteLine("число "+ a + " является четным");
}
else
{
    Console.WriteLine("число "+ a + " является нечетным");
}