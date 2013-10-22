using System.Collections.Generic;

namespace Snake.Model
{
    /// <summary>
    ///     Змейка
    /// </summary>
    public class Змейка
    {
        // Змейка состоит из нескольких клеток
        private readonly SnakeEvents snakeEvents;
        public List<SnakeCell> Cells = new List<SnakeCell>();

        // Поворот головы
        public Direction Direction;

        /// <summary>
        ///     Создание змейки.
        ///     Змейка будет состоять из 3-х клеток
        /// </summary>
        /// <param name="x">x-координата головы змеи</param>
        /// <param name="y">y-координата головы змеи</param>
        public Змейка(int x, int y, SnakeEvents snakeEvents)
        {
            this.snakeEvents = snakeEvents;
            Direction = Direction.Right;

            Cells.Clear();
            Cells.Add(new SnakeCell(x, y));
            Cells.Add(new SnakeCell(x - 1, y));
            Cells.Add(new SnakeCell(x - 2, y));
        }

        /// <summary>
        ///     Одно движение змейки
        /// </summary>
        public void Move()
        {
            // Двигаем все остальные ячейки
            for (int i = Cells.Count - 1; i > 0; i--)
            {
                Cells[i].x = Cells[i - 1].x;
                Cells[i].y = Cells[i - 1].y;
                Cells[i].UpdatePictureLocation();
            }
            // Двигаем голову
            SnakeCell head = Cells[0];
            switch (Direction)
            {
                case Direction.Up:
                    head.y--;
                    break;
                case Direction.Down:
                    head.y++;
                    break;
                case Direction.Left:
                    head.x--;
                    break;
                case Direction.Right:
                    head.x++;
                    break;
            }
            head.UpdatePictureLocation();

            if (!Поле.головаВПределахПоля(head))
            {
                snakeEvents.KillSnake();
                snakeEvents.StartGame();
            }
        }

        /// <summary>
        ///     Повернуть голову
        /// </summary>
        /// <param name="dir">Направление</param>
        public void TurnHead(Direction dir)
        {
            Direction = dir;
        }
    }
}