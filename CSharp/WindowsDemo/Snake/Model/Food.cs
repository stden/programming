using System;
using System.Windows.Forms;

namespace Snake.Model
{
	/// <summary>
	/// Еда для змейки
	/// </summary>
	public class Food : Cell
	{
		// Шаблон ячейки такого типа 
		public static PictureBox template;		
		
		public Food(int x, int y) : base(x,y,template)
		{
			
		}
	}
}
