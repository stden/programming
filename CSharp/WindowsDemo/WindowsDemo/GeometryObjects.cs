using System;

namespace WindowsDemo
{
	public class Shape
	{
		public virtual String draw(){
			return "Я - фигура!";
		}
	}
	
	public class Point : Shape {
		public double x,y;  
		
		public Point(double x, double y){
			this.x = x;
			this.y = y;
		}
		
		public override String draw(){
			return "Точка: ("+x+", "+y+")";
		}
	}
	
	public class Circle : Shape {
		public Point center;
		public double radius; 
		
		public override String draw(){			
			return "Окружность: центр "+center.draw()+" радиус: "+radius;
		}
	}

	public class Square : Shape {
		// Левый верхний угол
		public Point leftUpperCorner;
		// Правый нижний угол
		public Point rightBottomCorner;

        public Square(Point leftUpperCorner, Point rightBottomCorner){
			this.leftUpperCorner = leftUpperCorner;
			this.rightBottomCorner = rightBottomCorner;
		}

		public override String draw(){			
			return "Квадрат: Левый верхний угол "+leftUpperCorner.draw()+
				" Правый нижний угол: "+rightBottomCorner.draw();
		}		
	}
	
	public class Triangle : Shape {
		// Три вершины
		public Point a,b,c;
		
		public override String draw(){			
			return "Треугольник: " + a.draw() + " " 
			                  + b.draw()+ " " + c.draw();
		}		
		
	}
	
}
