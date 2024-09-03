using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpArithmeticOperatorExercises
{
	public class ArithmeticOperators
	{
		// Q1
		public static double CalcCircleCircumference(double radius)
		{
			return 2 * Math.PI * radius;
		}

		// Q2
		public static double CalcCircleArea(double radius)
		{
			return Math.PI * Math.Pow(radius, 2); // User Math.Pow to raise a number to a power
		}

		// Q3
		public static bool IsDivisible(double numA, double numB)
		{
			return numA % numB == 0;
		}

		// Q4
		public static double Pythagoras(double sideA, double sideB)
		{
			return Math.Sqrt(Math.Pow(sideA, 2) + Math.Pow(sideB, 2));
		}


		// Q5
		public static void BookAllocator()
		{
			Console.Write("Please enter the number of students: ");
			string studentInput = Console.ReadLine() ?? string.Empty;
			int numStudents = Convert.ToInt32(studentInput);

			Console.Write("Please enter the number of books: ");
			string bookInput = Console.ReadLine() ?? string.Empty;
			int numBooks = Convert.ToInt32(bookInput);

			int booksPerStudent = numBooks / numStudents;
			int booksLeftover = numBooks % numStudents;

			Console.WriteLine($"Each student will get {booksPerStudent} books");
			Console.WriteLine($"There will be {booksLeftover} leftover");
		}

		// Q6
		public static int BlocksRequired(double fileSizeInKibibytes)
		{
			const int BlockSize = 512;
			const int KibiToByte = 1024;
			double blocksNeeded = Math.Ceiling(fileSizeInKibibytes * KibiToByte / BlockSize);
			return (int)(blocksNeeded);
		}

		// Q7
		public static void CalcPocketMoney()
		{
			Console.Write("Please input the total amount of pocket money earned each week in £: ");
			decimal pocketMoney = Convert.ToDecimal(Console.ReadLine());

			Console.Write("Please input the amount you want to save as a percentage: ");
			decimal savePercentage = Convert.ToDecimal(Console.ReadLine());

			decimal moneySaved = pocketMoney * savePercentage / 100;

			decimal moneySavedYear = moneySaved * 52;

			// C formats the number as a currency
			Console.WriteLine($"You will save {moneySaved:C} per week and {moneySavedYear:C} per year.");
		}

	}
}
