using System;

namespace Snake
{
    /// <summary>
    /// Этот класс не относится к игре "Змейка", он для демонстрации работы с
    /// модульными тестами (unit-tests)
    /// </summary>
    public static class F
    {
        // Бесконечно малое число для сравнений
        private const double Eps = 1e-20;

        // Кеш для чисел Фибоначчи
        private static readonly long[] cashe = new long[1000];

        public static long Fact(int n)
        {
            if (n >= 2)
                return n*Fact(n - 1);
            return 1;
        }

        /// <summary>
        /// Вычисление чисел Фибоначчи при помощи кеша значений
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static long Fibonacci(int n)
        {
            // Если значение уже вычислялось => сразу возвращаем его            
            if (cashe[n] != 0)
                return cashe[n];

            // Если не вычислялось => 1. Вычисляем
            long result;
            if (n >= 3)
                result = Fibonacci(n - 1) + Fibonacci(n - 2);
            else
                result = n == 0 ? 0 : 1;

            // 2. Сохраняем в кеш
            cashe[n] = result;

            // 3. Возвращаем
            return result;
        }

        /// <summary>
        ///     Медленное вычисление числа Фибоначчи
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static long FibSlow(int n)
        {
            if (n >= 3)
                return FibSlow(n - 1) + FibSlow(n - 2);
            return n == 0 ? 0 : 1;
        }

        /// <summary>
        ///     Проверка корней квадратного уравнения Ax^2+Bx+C=0;
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <param name="roots">Массив корней</param>
        public static void CheckRoots(double a, double b, double c, double[] roots)
        {
            foreach (var x in roots)
            {
                var res = a*x*x + b*x + c;
                if (Math.Abs(res) > Eps)
                    throw new Exception("Корень " + x + " не подходит " + a + "x^2 + " + b + "x + " + c + " = 0");
            }
            // Все корни подходят => ничего не делаем
        }

        /// <summary>
        ///     Решение квадратного уравнения ax^2+bx+c=0
        /// </summary>
        /// <param name="a">Коэффициент a</param>
        /// <param name="b">Коэффициент b</param>
        /// <param name="c">Коэффициент c</param>
        /// <returns></returns>
        public static double[] Roots(double a, double b, double c)
        {
            if (Math.Abs(a) < Eps)
            {
                if (Math.Abs(b) > Eps) return new[] {-c/a};
                if (Math.Abs(c) < Eps)
                    throw new Exception("x-любое");
                return new double[] {};
            }

            // Вычисляем Дискриминант 
            double D = Math.Pow(b, 2) - 4*a*c;
            if (Math.Abs(D) < Eps)
                return new[] {-b/(2*a)};
            if (D > 0)
                return new[]
                {
                    (-b + Math.Sqrt(D))/(2*a),
                    (-b - Math.Sqrt(D))/(2*a)
                };

            return new double[] {};
        }

        public static void CheckEquation(double a, double b, double c)
        {
            // Вычисляем корни
            double[] xx = Roots(a, b, c);
            // Проверяем корни уравнения
            CheckRoots(a, b, c, xx);
        }
    }
}