using System;
public class pract2
{
	public static void Main(string[] args)
	{
	 int number1, number2, number3;
	 Console.Write("\n Input the First Number:");
	 number1 = Convert.ToInt32(Console.ReadLine());
	 Console.Write("\n Input the Second Number:");
	 number2 = Convert.ToInt32(Console.ReadLine());
	 Console.Write("\n Input the Second Number:");
	 number3 = Convert.ToInt32(Console.ReadLine());
	 
	 Console.Write("Result of specified numbers {0}, {1} 	 and {2}, (x+y).z is {3} and x.y + y.z is {4}\n\n",
	 number1, number2, number3, ((number1 + number2) * number3), (number1 * number2 + number2 * number3));
	}
    }