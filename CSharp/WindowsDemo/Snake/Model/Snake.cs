using System;
using System.Collections.Generic;

namespace Snake.Model
{
	/// <summary>
	/// Змейка
	/// </summary>
	public class SnakeObject
	{
		// Змейка состоит из нескольких клеток
		public List<SnakeCell> cells = new List<SnakeCell>();
		
		// Поворот головы
		public Direction direction; 
		
		/// <summary>
		/// Создание змейки. 
		/// Змейка будет состоять из 3-х клеток 
		/// </summary>
		/// <param name="x">x-координата головы змеи</param>
		/// <param name="y">y-координата головы змеи</param>
		public SnakeObject(int x, int y)
		{
			direction = Direction.Right;
			
			cells.Add(new SnakeCell(x, y));
			cells.Add(new SnakeCell(x-1, y));
			cells.Add(new SnakeCell(x-2, y));
		}
		
		public void Move(){
			// Двигаем все остальные ячейки
			for(int i = cells.Count-1; i > 0; i--){
				cells[i].x = cells[i-1].x;
                cells[i].y = cells[i-1].y;				
                cells[i].UpdatePictureLocation();
			}
			// Двигаем голову
			SnakeCell head = cells[0];
			switch(direction){
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
		}
		
		/// <summary>
		/// Повернуть голову
		/// </summary>
		/// <param name="dir">Направление</param>
		public void turnHead(Direction dir)
		{
			direction = dir;			
		}
	}
}
