using System;
/// <summary>
/// При переработке радиоактивных материалов образуются отходы двух видов — особо опасные (тип A) и неопасные (тип B).
/// Для их хранения используются одинаковые контейнеры. После помещения отходов в контейнеры последние укладываются
/// вертикальной стопкой. Стопка считается взрывоопасной, если в ней подряд идет более одного контейнера типа A.
/// Стопка считается безопасной, если она не является взрывоопасной. Для заданного количества контейнеров N
/// определить количество возможных типов безопасных стопок.
/// </summary>
namespace Waste
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine(fib(n));
            Console.ReadLine();
        }

        static int fib(int n)
        {
            if (n == 0)
            {
                return 1;
            }

            int prev = 1;
            int current = 1;
            for (int i = 2; i <= n; i++)
            {
                int temp = current;
                current += prev;
                prev = temp;
            }
            return current + 1;
        }
    }
}
