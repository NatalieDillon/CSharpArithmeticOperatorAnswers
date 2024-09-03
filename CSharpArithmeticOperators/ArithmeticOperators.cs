using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpArithmeticOperatorExercises
{
	public class ArithmeticOperators
	{
		public static double CalcCircleCircumference(double radius)
		{
			return 2 * Math.PI * radius;
		}

		public static double CalcCircleArea(double radius)
		{
			return Math.PI * Math.Pow(radius, 2); // User Math.Pow to raise a number to a power
		}


	}
}
