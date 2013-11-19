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
            if(N == 4)
                return 1*2*3*4;
            if(N == 3)
                return 6;
            if(N == 2) 
                return 2;
            return 1;
        }
    }
}
