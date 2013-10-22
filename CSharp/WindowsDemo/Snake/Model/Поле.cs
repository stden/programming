using System;
using System.Collections.Generic;

namespace Snake.Model
{
    /// <summary>
    ///     Карта (поле)
    /// </summary>
    internal class Поле
    {
        public static int высота;
        public static int ширина;

        internal static Змейка змейка;

        /// <summary>
        ///     Еда на поле
        /// </summary>
        public static List<Food> food = new List<Food>();

        public static MapEvents форма;

        private static readonly Random random = new Random();

        /// <summary>
        ///     Находится ли голова змейки в пределах поля?
        /// </summary>
        /// <param name="head"></param>
        public static bool головаВПределахПоля(SnakeCell head)
        {
            // Проверить, что x головы находится в пределах 1..ширина
            if (head.x < 1 || head.x > ширина)
                return false;
            // Проверить, что y головы находится в пределах 1..высота
            if (head.y < 1 || head.y > высота)
                return false;
            return true;
        }

        public static void Move()
        {
            змейка.Move();
            for (int i = 0; i < food.Count; i++)
            {
                food[i].Move();
                if (food[i].надоУбрать())
                {
                    KillFood(food[i]);
                }
            }
            // Время от времени должна появляться еда в случайной точке поля
            if (random.Next(4) == 0) // Раз в сколько-то ходов появляется еда
            {
                CreateFood(random.Next(ширина) + 1, random.Next(высота) + 1);
            }

            // TODO: Проверять, что змея сьела еду и вызывать у змеи метод "вырасти на клетку"
        }


        public static void CreateFood(int x, int y)
        {
            var food = new Food(x, y);
            форма.Добавить(food.picture);
            Поле.food.Add(food);
        }

        public static void KillFood(Food food)
        {
            форма.Убрать(food.picture);
            Поле.food.Remove(food);
        }
    }
}