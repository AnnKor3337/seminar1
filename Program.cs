/* Решение задачи №2

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

Console.WriteLine("max="+ max + "; min="+ min); */



/* Решение задачи №4

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
} */



/* Решение задачи №6

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
} */



/* Решение задачи №8

int n, i;

Console.WriteLine("Введите число n");
n = Convert.ToInt32(Console.ReadLine());

i=0;
while (i<=n-2)
{
    Console.WriteLine(i+=2);
} */