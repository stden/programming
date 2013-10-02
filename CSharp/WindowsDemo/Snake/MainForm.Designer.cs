using System.Windows.Forms;
using Snake.Model;

namespace Snake
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.startGameButton = new System.Windows.Forms.Button();
			this.SnakeCellTemplate = new System.Windows.Forms.PictureBox();
			this.FoodTemplate = new System.Windows.Forms.PictureBox();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			((System.ComponentModel.ISupportInitialize)(this.SnakeCellTemplate)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.FoodTemplate)).BeginInit();
			this.SuspendLayout();
			// 
			// startGameButton
			// 
			this.startGameButton.Location = new System.Drawing.Point(24, 12);
			this.startGameButton.Name = "startGameButton";
			this.startGameButton.Size = new System.Drawing.Size(75, 23);
			this.startGameButton.TabIndex = 0;
			this.startGameButton.Text = "Старт";
			this.startGameButton.UseVisualStyleBackColor = true;
			this.startGameButton.Click += new System.EventHandler(this.StartGameButtonClick);
			// 
			// SnakeCellTemplate
			// 
			this.SnakeCellTemplate.Image = ((System.Drawing.Image)(resources.GetObject("SnakeCellTemplate.Image")));
			this.SnakeCellTemplate.Location = new System.Drawing.Point(118, 3);
			this.SnakeCellTemplate.Name = "SnakeCellTemplate";
			this.SnakeCellTemplate.Size = new System.Drawing.Size(32, 32);
			this.SnakeCellTemplate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.SnakeCellTemplate.TabIndex = 1;
			this.SnakeCellTemplate.TabStop = false;
			this.SnakeCellTemplate.Visible = false;
			// 
			// FoodTemplate
			// 
			this.FoodTemplate.Image = ((System.Drawing.Image)(resources.GetObject("FoodTemplate.Image")));
			this.FoodTemplate.Location = new System.Drawing.Point(167, 3);
			this.FoodTemplate.Name = "FoodTemplate";
			this.FoodTemplate.Size = new System.Drawing.Size(32, 32);
			this.FoodTemplate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.FoodTemplate.TabIndex = 2;
			this.FoodTemplate.TabStop = false;
			this.FoodTemplate.Visible = false;
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Interval = 1000;
			this.timer1.Tick += new System.EventHandler(this.Timer1Tick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(587, 293);
			this.Controls.Add(this.FoodTemplate);
			this.Controls.Add(this.SnakeCellTemplate);
			this.Controls.Add(this.startGameButton);
			this.KeyPreview = true;
			this.Name = "MainForm";
			this.Text = "Змейка";
			((System.ComponentModel.ISupportInitialize)(this.SnakeCellTemplate)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.FoodTemplate)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.PictureBox FoodTemplate;
		private System.Windows.Forms.PictureBox SnakeCellTemplate;
		private System.Windows.Forms.Button startGameButton;
		
		void StartGameButtonClick(object sender, System.EventArgs e)
		{
			StartGame();
		}
		
		void Timer1Tick(object sender, System.EventArgs e)
		{
			snake.Move();
		}
		
		// Обработчик нажатий "стрелок" на клавиатуре
		protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
		{
			// Для всех обрабатываемых клавиш возвращаем true
			if (keyData == Keys.Left)
			{
				snake.turnHead(Direction.Left);
				return true;
			}
			else if (keyData == Keys.Right)
			{
				snake.turnHead(Direction.Right);
				return true;
			}
			else if (keyData == Keys.Up)
			{
				snake.turnHead(Direction.Up);
				return true;
			}
			else if (keyData == Keys.Down)
			{
				snake.turnHead(Direction.Down);
				return true;
			}
			else
				return base.ProcessCmdKey(ref msg, keyData);
		}
	}
}
