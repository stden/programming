using System.Collections.Generic;

namespace Snake.Model
{
    /// <summary>
    ///     Змейка
    /// </summary>
    public class Змейка
    {
        // Змейка состоит из нескольких клеток
        private readonly ISnakeEvents _snakeEvents;
        public List<SnakeCell> Cells = new List<SnakeCell>();

        // Поворот головы
        public Direction Direction;

        /// <summary>
        ///     Создание змейки.
        ///     Змейка будет состоять из 3-х клеток
        /// </summary>
        /// <param name="x">x-координата головы змеи</param>
        /// <param name="y">y-координата головы змеи</param>
        /// <param name="snakeEvents"></param>
        public Змейка(int x, int y, ISnakeEvents snakeEvents)
        {
            _snakeEvents = snakeEvents;
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
                Cells[i].X = Cells[i - 1].X;
                Cells[i].Y = Cells[i - 1].Y;
                Cells[i].UpdatePictureLocation();
            }
            // Двигаем голову
            SnakeCell head = Cells[0];
            switch (Direction)
            {
                case Direction.Up:
                    head.Y--;
                    break;
                case Direction.Down:
                    head.Y++;
                    break;
                case Direction.Left:
                    head.X--;
                    break;
                case Direction.Right:
                    head.X++;
                    break;
            }
            head.UpdatePictureLocation();

            if (Поле.ГоловаВПределахПоля(head)) return;

            _snakeEvents.KillSnake();
            _snakeEvents.StartGame();
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