// Решение задачи №4

int a, b, c, max;

Console.WriteLine("Введите число a");
a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число b");
b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число c");
c = Convert.ToInt32(Console.ReadLine());

max=a;

if (max>=b)
{
    max=a;
}
else
{
    max=b;
}

if (max>=c)
{
    Console.WriteLine("max="+ max);
}
else
{
    max=c;
    Console.WriteLine("max="+ max);
}