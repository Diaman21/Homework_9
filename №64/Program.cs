//Задача 64: Задайте значения M и N. 
//Напишите рекурсивный метод, который выведет все натуральные числа кратные 3-ём в промежутке от M до N.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Write("Введите значение M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение N: ");
int n = Convert.ToInt32(Console.ReadLine());
if (m > n) 
{
    Console.WriteLine("Введено некорректное значение N");
    Console.Write("Введите значение N: ");
}
void OutputNum(int m, int n)
{
    if (m <= n)
    {
        if (m % 3 == 0)
        {
            Console.Write($"{m}"+" ");
            m++;
            OutputNum(m, n);
        }
        else
        {
            m++;
            OutputNum(m, n);
        }
    }
}
OutputNum(m, n);