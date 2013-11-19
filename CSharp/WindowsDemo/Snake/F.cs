using System;

namespace Snake
{
    /// <summary>
    /// Этот класс не относится к игре, он для демонстрации работы с 
    /// модульными тестами (unit-tests)
    /// </summary>
    static public class F
    {               
        public static long Fact(int N)
        {
            if(N >= 2) 
                return N*Fact(N-1);
            return 1;
        }
        
        static long[] cashe = new long[1000];
        
        public static long Fib(int N)
        {
            // Если значение уже вычислялось => сразу возвращаем его            
            if(cashe[N]!=0)
                return cashe[N];
            
            // Если не вычислялось => 1. Вычисляем
            long result;
            if(N >= 3) 
                result = Fib(N-1) + Fib(N-2);
            else 
                result = 1;
            
            // 2. Сохраняем в кеш
            cashe[N] = result; 
            
            // 3. Возвращаем
            return result;
        }
        
        public static long FibSlow(int N)
        {
            if(N >= 3) 
                return FibSlow(N-1) + FibSlow(N-2);
            return 1;            
        }
        
        const double eps = 1e-20;
            
        /// <summary>
        /// Проверка корней квадратного уравнения Ax^2+Bx+C=0;
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <param name="xx">Массив корней</param>
        public static void checkRoots(double a, double b, double c, double[] xx){
            foreach(double x in xx){
                double res = a*x*x + b*x + c;
                if(Math.Abs(res) > eps)
                    throw new Exception("Корень "+x+" не подходит "+a+"x^2 + "+b+"x + "+c+" = 0");
            }
            // Все корни подходят => ничего не делаем
        }
        
        /// <summary>
        /// Решение квадратного уравнения 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        public static double[] roots(double a, double b, double c){
            if(Math.Abs(a) < eps){
                if(Math.Abs(b) < eps){
                    if(Math.Abs(c) < eps)
                        throw new Exception("x-любое");
                    return new double[0]{};                    
                } else {                                        
                    return new double[1]{ -c / a };
                }                              
            }
            
            double D = Math.Pow(b,2) - 4*a*c;
            if(Math.Abs(D) < eps)
                return new double[1]{ -b/(2*a) };
            if(D > 0)
                return new double[2]{  
                  (-b+Math.Sqrt(D))/(2*a),
                  (-b-Math.Sqrt(D))/(2*a) 
                };
            
            return new double[0]{};
        }
        
        public static void checkEq(double a, double b, double c)
        {
            // Вычисляем корни
            double[] xx = roots(a,b,c);
            // Проверяем корни уравнения
            checkRoots(a,b,c,xx);
        }
    }
}
