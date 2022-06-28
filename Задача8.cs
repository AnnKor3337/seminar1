// Решение задачи №8

int n, i;

Console.WriteLine("Введите число n");
n = Convert.ToInt32(Console.ReadLine());

i = 0;
while (i<=n-2)
{
    Console.WriteLine(i+=2);
}