using System.Windows.Forms;
using Snake.Model;

namespace Snake
{
    /// <summary>
    ///     Основная форма
    /// </summary>
    public partial class MainForm : Form, ISnakeEvents, IMapEvents
    {
        public MainForm()
        {
            //
            // The InitializeComponent() call is required for Windows Forms designer support.
            //
            InitializeComponent();

            StartGame();
        }

        public void ДобавитьКартинку(PictureBox picture)
        {
            Controls.Add(picture);
        }

        public void УбратьКартинку(PictureBox picture)
        {
            Controls.Remove(picture);
        }

        public void StartGame()
        {
            // Высота поля клетки
            Поле.Высота = ClientSize.Height/SnakeCellTemplate.Height;
            // Ширина поля клетки			
            Поле.Ширина = ClientSize.Width/SnakeCellTemplate.Width;

            Food.Template = FoodTemplate;
            SnakeCell.Template = SnakeCellTemplate;

            Поле.Форма = this;
            
            Поле.Змейка = new Змейка(Поле.Ширина/2, Поле.Высота/2, this);

            Поле.CreateFood(Поле.Ширина/2 + 3, Поле.Высота/2 + 2);
            Поле.CreateFood(Поле.Ширина/2 + 5, Поле.Высота/2 - 2);
        }

        public void GameOver(string gameResult)
        {
            gameTimer.Enabled = false;
            
            MessageBox.Show("Игра окончена! "+gameResult);
            
            gameTimer.Enabled = true;
            
            // Удалим с формы все клетки змейки
            foreach (SnakeCell cell in Поле.Змейка.Cells)
            {
                Controls.Remove(cell.Picture);
            }
        }
    }
}