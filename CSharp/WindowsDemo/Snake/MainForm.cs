using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Snake.Model;

namespace Snake
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		private SnakeObject snake;
		int fieldHeight;
		int fieldWidth;
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			StartGame();
		}
		
		public void StartGame() {
			// Высота поля клетки
			fieldHeight = this.ClientSize.Height / SnakeCellTemplate.Height;
			// Ширина поля клетки			
			fieldWidth = this.ClientSize.Width / SnakeCellTemplate.Width;
			Console.WriteLine("" + fieldHeight + " x " + fieldWidth);
			
			Food.template = FoodTemplate;
            SnakeCell.template = SnakeCellTemplate;			
				
			snake = new SnakeObject(fieldWidth / 2, fieldHeight / 2);
			
			foreach(SnakeCell cell in snake.cells){
				Controls.Add(cell.picture);
			}
			Food food = new Food(fieldWidth / 2 + 3, fieldHeight / 2 + 2);
			Controls.Add(food.picture);
			
			Food food2 = new Food(fieldWidth / 2 + 5, fieldHeight / 2 - 2);
			Controls.Add(food2.picture);
		}
	}
}
