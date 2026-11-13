using System;

namespace WindowsDemo.GetSetDemo
{
	// геттеры, сеттеры
	public class Square
	{
		private double side;
		
		public double getSide(){
			return side;
		}
		
		public void setSide(double value){
			side = value;
		}
		
		public double getArea(){
			return side * side;
		}
		
		public void setArea(double value){
			side = Math.Sqrt(value);
		}
	}
	
	public class Square2
	{
		private double area;
		
		public double getSide(){
			return Math.Sqrt(area);
		}
		
		public void setSide(double value){
			area = value * value;
		}
		
		public double getArea(){
			return area;
		}
		
		public void setArea(double value){
			area = value;
		}
	}
	
	// Использование свойств в C#
	public class Square3
	{
		private double side;
		
		public double Side {
			get {
				return side;
			}
			set {
				side = value;
			}
		}
		
		public double Area {
			get {
			     return side * side;
			}
			set {
				side = Math.Sqrt(value);				
			}
		}		
	}	
}
