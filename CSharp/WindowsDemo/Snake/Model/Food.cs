﻿using System.Windows.Forms;

namespace Snake.Model
{
    /// <summary>
    /// Еда для змейки
    /// </summary>
    public class Food : Cell
    {
        // Время до "пропадания" еды
        const int foodLife = 20;  
            
        // Шаблон ячейки такого типа 
        public static PictureBox Template;

        private int _time;

        public Food(int x, int y) : base(x, y, Template)
        {
            _time = 0;
        }

        public void Move()
        {
            _time++;
        }

        public bool НадоУбрать()
        {
            return _time > foodLife;
        }
    }
}