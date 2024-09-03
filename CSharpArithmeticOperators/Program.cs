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

			// Q3
			double num1 = -8;
			double num2 = 4;
			bool divisible = ArithmeticOperators.IsDivisible(num1, num2);
			Console.WriteLine($"It is {divisible} that {num1} is divisible by {num2}\n");

			// Q4
			double sideA = 3;
			double sideB = 4;
			double hypotenuse = ArithmeticOperators.Pythagoras(sideA, sideB);
			Console.WriteLine($"The hypotenuse is {hypotenuse}\n");

			// Q5
			ArithmeticOperators.BookAllocator();
			Console.WriteLine();

			// Q6
			double fileSize = 19.7;
			int blocksRequired = ArithmeticOperators.BlocksRequired(fileSize);
			Console.WriteLine($"{blocksRequired} blocks are needed\n");

			// Q7
			ArithmeticOperators.CalcPocketMoney();
			
		}
	}
}