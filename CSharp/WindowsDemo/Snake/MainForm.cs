using System.Windows.Forms;
using Snake.Model;

namespace Snake
{
    /// <summary>
    /// Основная форма
    /// </summary>
    public partial class MainForm : Form, SnakeEvents, MapEvents
    {
        public MainForm()
        {
            //
            // The InitializeComponent() call is required for Windows Forms designer support.
            //
            InitializeComponent();

            StartGame();
        }

        public void Добавить(PictureBox picture)
        {
            Controls.Add(picture);
        }

        public void Убрать(PictureBox picture)
        {
            Controls.Remove(picture);
        }

        public void StartGame()
        {
            // Высота поля клетки
            Поле.высота = ClientSize.Height/SnakeCellTemplate.Height;
            // Ширина поля клетки			
            Поле.ширина = ClientSize.Width/SnakeCellTemplate.Width;

            Food.Template = FoodTemplate;
            SnakeCell.template = SnakeCellTemplate;

            Поле.змейка = new Змейка(Поле.ширина/2, Поле.высота/2, this);

            foreach (SnakeCell cell in Поле.змейка.cells)
            {
                Controls.Add(cell.picture);
            }
            Поле.форма = this;
            Поле.CreateFood(Поле.ширина/2 + 3, Поле.высота/2 + 2);
            Поле.CreateFood(Поле.ширина/2 + 5, Поле.высота/2 - 2);
        }

        public void KillSnake()
        {
            // Удалим с формы все клетки змейки
            foreach (SnakeCell cell in Поле.змейка.cells)
            {
                Controls.Remove(cell.picture);
            }
        }
    }
}