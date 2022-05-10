// Создайте функцию, которая возвращает n-й элемент последовательности Фибоначчи
// int fibo(int n)
// {
//     if (n==1 || n == 2) return 1;
//     return fibo(n-1) + fibo(n-2);
// }

// DateTime dt = DateTime.Now;
// System.Console.WriteLine(dt);

// System.Console.WriteLine(fibo(5));

// System.Console.WriteLine(DateTime.Now);
// System.Console.WriteLine((DateTime.Now - dt).TotalMilliseconds); //смотрим, сколько времени будет выполняться расчет
// Очень долго с помощью рекурсии вычисляются большие числа


// Решение с помощью for:
double fibo(int n)
{
    if (n==1 || n == 2) return 1;
    double a = 0;
    double b = 1;
    double c = 0;

    for (int i = 1; i < n; i++)
    {
        c = a + b;
        a = b;
        b = c;
    }
    return c;
}

DateTime dt = DateTime.Now;
System.Console.WriteLine(dt);

System.Console.WriteLine(fibo(6));

System.Console.WriteLine(DateTime.Now);
System.Console.WriteLine((DateTime.Now - dt).TotalMilliseconds);