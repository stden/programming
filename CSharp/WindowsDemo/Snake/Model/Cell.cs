using System;
using System.Drawing;
using System.Windows.Forms;

namespace Snake.Model
{
    /// <summary>
    /// Клетка змейки или еда
    /// </summary>
    public class Cell
    {
        // Картинка
        public PictureBox picture;

        /// <summary>
        ///     Координаты клетки
        /// </summary>
        public int x, y;

        /// <summary>
        ///     Конструктор
        /// </summary>
        /// <param name="x">x-координата клетки</param>
        /// <param name="y">y-координата клетки</param>
        public Cell(int x, int y, PictureBox template)
        {
            this.x = x;
            this.y = y;
            Console.WriteLine("x = " + x + " y = " + y);

            picture = new PictureBox();
            picture.Image = template.Image;
            picture.Width = template.Width;
            picture.Height = template.Height;

            UpdatePictureLocation();
        }

        // Пересчитываем x, y в экранные координаты
        public void UpdatePictureLocation()
        {
            picture.Location = new Point(
                x*picture.Image.Width, y*picture.Image.Height);
        }
    }
}