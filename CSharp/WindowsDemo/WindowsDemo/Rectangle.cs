using System;

namespace WindowsDemo
{
	// Прямоугольник 
	public class Rectangle
	{
		public int a, b; // Стороны прямоугольника
		private int privateInt; 
		
		// Площадь прямоугольника
		public int Area()
		{
			return a * b;
		}
		
		// Конструктор по-умолчанию
		public Rectangle(){			
		}
		
		// Конструктор с параметрами
		public Rectangle(int a, int b){
			this.a = a; 
			this.b = b;
		}
	}
}
