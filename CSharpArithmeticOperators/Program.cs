using System.Numerics;

namespace CSharpArithmeticOperatorExercises
{
	internal class Program
	{
		static void Main()
		{
			// Q1
			double circumferenceCircle = ArithmeticOperators.CalcCircleCircumference(1.2);
			Console.WriteLine($"The circumference of the circle is {Math.Round(circumferenceCircle, 2)}\n");

			// Q2
			double areaCircle = ArithmeticOperators.CalcCircleArea(1.2);
			Console.WriteLine($"The area of the circle is {Math.Round(areaCircle,2)}\n");

			
		}
	}
}