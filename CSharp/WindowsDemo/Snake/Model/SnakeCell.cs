using System.Windows.Forms;

namespace Snake.Model
{
    /// <summary>
    ///     Клетка змейки
    /// </summary>
    public class SnakeCell : Cell
    {
        // Шаблон ячейки такого типа 
        public static PictureBox template;

        public SnakeCell(int x, int y) : base(x, y, template)
        {
        }
    }
}