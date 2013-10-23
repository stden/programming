using System.Drawing;
using System.Windows.Forms;

namespace Snake.Model
{
    /// <summary>
    ///     Клетка змейки или еда
    /// </summary>
    public class Cell
    {
        // Картинка
        public PictureBox Picture;

        /// <summary>
        ///     Координаты клетки
        /// </summary>
        public int X, Y;

        /// <summary>
        ///     Конструктор
        /// </summary>
        /// <param name="x">x-координата клетки</param>
        /// <param name="y">y-координата клетки</param>
        /// <param name="template">Картинка-шаблон для этой клетки</param>
        public Cell(int x, int y, PictureBox template)
        {
            X = x;
            Y = y;

            Picture = new PictureBox {Image = template.Image, Width = template.Width, Height = template.Height};

            UpdatePictureLocation();
        }

        // Пересчитываем x, y в экранные координаты
        public void UpdatePictureLocation()
        {
            Picture.Location =
                new Point(X*Picture.Image.Width, Y*Picture.Image.Height);
        }
    }
}