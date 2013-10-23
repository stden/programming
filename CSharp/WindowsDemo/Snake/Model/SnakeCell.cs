using System.Windows.Forms;

namespace Snake.Model
{
    /// <summary>
    ///     Клетка змейки
    /// </summary>
    public class SnakeCell : Cell
    {
        // Картинка-шаблон для клетки змейки 
        public static PictureBox Template;

        public SnakeCell(int x, int y) : base(x, y, Template)
        {
        }
    }
}