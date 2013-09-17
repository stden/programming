using System;
using System.Windows.Forms;
using WindowsDemo.GetSetDemo;

namespace WindowsDemo
{
	/// <summary>
	/// Class with program entry point.
	/// </summary>
	internal sealed class Program
	{
		/// <summary>
		/// Program entry point.
		/// </summary>
		[STAThread]
		private static void Main(string[] args)
		{
//			Application.EnableVisualStyles();
//			Application.SetCompatibleTextRenderingDefault(false);
//			Application.Run(new MainForm());
			
			// ООП: классы и обьекты
			
			// Hello World на С#
			//Console.WriteLine("Hello world!");
			//Console.ReadLine();


			// PolymorphDemo();
			
			//new WindowsDemo.Square();
			new WindowsDemo.GetSetDemo.Square();
			
			var Square3 = new Square3();
			Square3.Area = 400;
			Console.WriteLine("Сторона: "+Square3.Side);
			Square3.Side = 3;
			Console.WriteLine("Сторона: "+Square3.Side+" Площадь: "+Square3.Area);
			
			
			Console.ReadLine();
			
		}

		static void PolymorphDemo()
		{
			// Используем созданный нами класс Rectangle
			Rectangle r = new Rectangle();
			r.a = 3;
			r.b = 20;
			Console.WriteLine("Площадь прямоугольника: " + r.Area());

			Rectangle r2 = new Rectangle();
			r2.a = 10;
			r2.b = 13;
			Console.WriteLine("r2 = " + r2.Area());

			Rectangle r3 = new Rectangle(5, 10);
			Console.WriteLine("r3 = " + r3.Area());

			ColoredRectangle cr = new ColoredRectangle();
			cr.a = 10;
			cr.b = 12;
			cr.Color = 1234;

			Shape[] shapes = new Shape[2];
			shapes[0] = new Point(2, 3);
			shapes[1] = new Square(new Point(0, 0), new Point(10, 10));
			//shapes[2]
			foreach (Shape s in shapes) {
				Console.WriteLine(s.draw());
			}
		}
		
	}
}
