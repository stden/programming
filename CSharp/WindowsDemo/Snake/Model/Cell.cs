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
		/// <summary>
		/// Координаты клетки
		/// </summary>
		public int x,y;		
		
		/// <summary>
		/// Конструктор
		/// </summary>
		/// <param name="x">x-координата клетки</param>
		/// <param name="y">y-координата клетки</param>
		public Cell(int x, int y, PictureBox template){
			this.x = x;
			this.y = y;
			Console.WriteLine("x = "+x+" y = "+y);
			
			this.picture = new PictureBox();
			this.picture.Image = template.Image;
			this.picture.Width = template.Width;
			this.picture.Height = template.Height;
			
			UpdatePictureLocation();												
		}	
		
		// Пересчитываем x, y в экранные координаты
		public void UpdatePictureLocation()
		{
		    picture.Location = new System.Drawing.Point(
				x * picture.Image.Width, y * picture.Image.Height);
		}
		
		// Картинка
		public PictureBox picture; 
	}
}
