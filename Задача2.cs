// Решение задачи №2

int a, b, max, min;

Console.WriteLine("Введите число a");
a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число b");
b = Convert.ToInt32(Console.ReadLine());

if (a>=b)
{
    max=a;
    min=b;
}
else
{
    max=b;
    min=a;
}

Console.WriteLine("max="+ max + "; min="+ min);