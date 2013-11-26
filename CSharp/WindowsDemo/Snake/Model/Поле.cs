using System;
using System.Collections.Generic;

namespace Snake.Model
{
    /// <summary>
    ///     Карта (поле)
    /// </summary>
    internal static class Поле
    {
        public static int Высота;
        public static int Ширина;

        internal static Змейка Змейка;

        /// <summary>
        ///     Еда на поле
        /// </summary>
        public static List<Food> food = new List<Food>();

        public static IMapEvents Форма;

        /// <summary>
        ///     Генератор случайных чисел
        /// </summary>
        private static readonly Random Random = new Random();

        /// <summary>
        ///     Находится ли голова змейки в пределах поля?
        /// </summary>
        /// <param name="head">Голова змейки</param>
        public static bool ГоловаВПределахПоля(SnakeCell head)
        {
            // Проверить, что x головы находится в пределах 1..ширина
            if (head.X < 1 || head.X > Ширина)
                return false;
            // Проверить, что y головы находится в пределах 1..высота
            if (head.Y < 1 || head.Y > Высота)
                return false;
            return true;
        }

        /// <summary>
        /// Общий "ход", "ходят" змейка, еда (все кто участвует в игровом процессе)
        /// </summary>
        public static void Move()
        {
            Змейка.Move();
            for (int i = 0; i < food.Count; i++)
            {
                food[i].Move();
                if (food[i].НадоУбрать())
                {
                    KillFood(food[i]);
                }
            }
            // Время от времени должна появляться еда в случайной точке поля
            if (Random.Next(4) == 0) // Раз в сколько-то ходов появляется еда
            {
                CreateFood(Random.Next(Ширина) + 1, Random.Next(Высота) + 1);
            }

            // Проверять, что змея сьела еду и вызывать у змеи метод "вырасти на клетку"
            // Сравниваем координаты "Еды" и головы змеи
            foreach(Food f in food){
                SnakeCell голова = Змейка.Cells[0];
                if(f.X == голова.X && f.Y == голова.Y){
                    // Процесс съедания 
                    Змейка.Вырасти();
                    // Уничтожаем еду
                    KillFood(f);
                    break;
                }
            }  
            //             
        }


        public static void CreateFood(int x, int y)
        {
            var f = new Food(x, y);
            Форма.ДобавитьКартинку(f.Picture);
            food.Add(f);
        }

        public static void KillFood(Food f)
        {
            Форма.УбратьКартинку(f.Picture);
            food.Remove(f);
        }
    }
}