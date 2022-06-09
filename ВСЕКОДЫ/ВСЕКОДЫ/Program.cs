// Реализация сторонних алгоритмов на C#

// Задание 1
Console.Write("Введите объём молока в литрах: ");
double x = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите плотность молока в кг/м^3: ");
double p = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Масса равна: " + (x * p) / 1000);

// Задание 2
Console.Write("a = ");
double a = Convert.ToDouble(Console.ReadLine());
Console.Write("b = ");
double b = Convert.ToDouble(Console.ReadLine());
Console.Write("c = ");
double c = Convert.ToDouble(Console.ReadLine());

if (a < b)
{
    if (b < c)
    {

        Console.WriteLine("Да. Неравенство выполняется");
    }
    else Console.WriteLine("Нет. Неравенство не выполняется");
}
else Console.WriteLine("Нет. Неравенство не выполняется");

// Задание 3
Console.Write("Введите размерность массива n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число x: ");
int x = Convert.ToInt32(Console.ReadLine());
int[] massiv = new int[n];
Random randNumb = new Random();
for (int i = 0; i < massiv.Length; i++)
{
    massiv[i] = randNumb.Next(0, 11);
    Console.WriteLine(massiv[i]);
}
Console.WriteLine();

int index1 = 0;
for (int j = 0; j < massiv.Length; j++)
{
    if (massiv[j] == x)
    {
        index1 = j;
        Console.WriteLine("Содержится в ячейке под номером:" + j);
    }
}
Console.ReadKey();

// Задание 4
Console.WriteLine("Введите число n");
string n = Console.ReadLine();
char[] mas = new char[n.Length];
for (int i = 0; i < n.Length; i++)
{
    mas[i] = n[i];
    Console.WriteLine(mas[i]);
}
double sum = 0;
for (int i = 0; i < mas.Length; i++)
{
    if ((Convert.ToInt32(mas[i].ToString()) % 2 == 0))
        sum += Convert.ToInt32(mas[i].ToString());
}
Console.WriteLine();
Console.WriteLine(sum);
Console.ReadLine();

// Задание 5
string n = Console.ReadLine();
int sum = Convert.ToInt32(n);
while (Convert.ToInt32(n) != 0)
{
    n = Console.ReadLine();
    sum += Convert.ToInt32(n);
}
Console.WriteLine("Сумма равна: " + sum.ToString());
Console.ReadLine();

// Задание 6
int a = 100;
int b = 200;
for (int i = a; i <= b; i++)
    while (a < b)
    {
        i % 3 == 0;
        Console.WriteLine(i);
    }

// Задания без вариантов

// Задание 1
namespace ulpr1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите дату (например: 23 июля 2003): ");
            var DATA = Console.ReadLine().ToString().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            uint a = Convert.ToUInt32(DATA[0]);
            string b = DATA[1];
            uint c = Convert.ToUInt32(DATA[2]);
            uint D = 0;
            string[] month = { "января", "февраля", "марта", "апреля", "мая", "июня", "июля", "августа", "сентября", "октября", "ноября", "декабря" };
            uint[] day = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            uint[] vday = { 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            for (int i = 0; i < 12; i++)
            {
                if ((c % 4 == 0 && c % 100 != 0) || (c % 400 == 0))
                {
                    if (b == month[i])
                    {
                        if (a > 0 && a <= vday[i])
                        {
                            uint x = D + a;
                            uint y = 366 - (D + a);
                            Console.WriteLine($"Корректная дата\n{x}\n{y}");
                        }
                        else Console.WriteLine("Некорректная дата");
                    }
                    D = D + vday[i];
                }
                else
                {
                    if (b == month[i])
                    {
                        if (a > 0 && a <= day[i])
                        {
                            uint x = D + a;
                            uint y = 365 - (D + a);
                            Console.WriteLine($"Корректная дата\n{x}\n{y}");
                        }
                        else Console.WriteLine("Некорректная дата");
                    }
                    D = D + day[i];
                }
            }
        }
    }
}

// Задание 4
Random rand = new Random();
int i = rand.Next(10);
int count = 1;
Console.WriteLine("Загадано число от 0 до 9. Игра состоит в том, чтобы отгадать его за 3 попытки");
Console.WriteLine("Введите первое число:");
int k = Convert.ToInt32(Console.ReadLine());
while (count <= 2)
{
    if (i > k)
    {
        Console.WriteLine("Неверно, загадано число больше введенного. Следующая попытка:");
        k = Convert.ToInt32(Console.ReadLine());
    }
    if (i < k)
    {
        Console.WriteLine("Неверно, загадано число меньше введенного. Следующая попытка:");
        k = Convert.ToInt32(Console.ReadLine());
    }
    if (i == k)
    {
        Console.WriteLine("Верно, загадано число " + k + " :)");
        k = Convert.ToInt32(Console.ReadLine());
        break;
    }
    else
    {
        count++;
        if (count == 3)
        {
            Console.WriteLine("Вам не удалось угадать. Это было число: " + i + " :(");
            break;
        }

    }

}
Console.ReadLine();

// Задание 5
using System;
namespace Sample5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("количество элементов массива = ");
            int N = int.Parse(Console.ReadLine());
            Random R = new Random();
            int[] A = new int[N];
            for (int i = 0; i < A.Length; i++)
            {
                A[i] = R.Next(-100, 100);
                Console.WriteLine(A[i]);
            }
            Console.WriteLine("\nНовый массив:");
            int[] mas = new int[N];
            for (int i = 0; i < mas.Length; i++)
            {
                int a = R.Next(1, mas.Length + 1);
                if (!mas.Contains(a)) mas[i] = a;
                else i--;
            }
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine(A[mas[i] - 1]);
            }
        }
    }
}

// Задание 8
using System.Security.Cryptography;
class Program
{
    public static byte RND()
    {
        RNGCryptoServiceProvider Rand = new RNGCryptoServiceProvider();
        byte[] randomNumber = new byte[1];
        Rand.GetBytes(randomNumber);
        return (randomNumber[0]);
    }
    static void Main(string[] args)
    {
        for (int i = 0; i < 100; i++)
        {
            double R = RND();
            Console.Write(R + "  ");
        }
    }
}

// Задание 3
using System;
namespace Sample5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите номер года ");
            int n = int.Parse(Console.ReadLine());
            int I = 0;
            int count = 0;
            int[] years = new int[n];
            int[] days = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            int[] visokosniydays = { 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            int[] Thursdays = new int[55];
            for (int i = 0; i < years.Length; i++)
            {
                int year = i + 1;
                for (int j = 0; j < 12; j++)
                {
                    if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
                    {
                        for (int k = 0; k < visokosniydays[j]; k++)
                        {
                            if (I == 7) { I = 0; }
                            if (year == n && I == 3)
                            {
                                Thursdays[count] = k + 1;
                                count++;
                            }
                            I++;
                        }
                    }
                    else
                    {
                        for (int k = 0; k < days[j]; k++)
                        {
                            if (I == 7) { I = 0; }
                            if (year == n && I == 3)
                            {
                                Thursdays[count] = k + 1;
                                count++;
                            }
                            I++;
                        }
                    }
                }
            }
            for (int m = 0; m < Thursdays.Length; m++)
            {
                if (m < Thursdays.Length - 1 && Thursdays[m] > Thursdays[m + 1])
                {
                    Console.Write(Thursdays[m] + " ");
                }
            }
        }
    }
}

