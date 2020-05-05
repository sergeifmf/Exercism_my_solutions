using System;

namespace RationalNumbers
{
	public static class RealNumberExtension
	{
		public static double Expreal(this int realNumber, RationalNumber r)
		{
			return Math.Pow(realNumber, (double)r.Numerator / r.Denominator);
		}
	}

	/// <summary>
	/// Class for arithmetical operations with rational numbers.
	/// </summary>
	public struct RationalNumber
	{
		public int Denominator { get; set; }

		public int Numerator { get; set; }

		/// <summary>
		/// Construct fraction, reducing to lower terms.
		/// </summary>
		/// <param name="numerator"> Fraction numerator. </param>
		/// <param name="denominator"> Fraction denominator. </param>
		public RationalNumber(int numerator, int denominator)
		{
			if (denominator == 0)
			{
				throw new DivideByZeroException("Denominator can't be zero");
			}

			if (numerator > 0 && denominator < 0)
			{
				numerator *= -1;
				denominator *= -1;
			}

			Numerator = numerator;
			Denominator = denominator;

			if (numerator == 0)
			{
				Denominator = 1;
				return;
			}

			if (numerator == denominator)
			{
				Numerator = 1;
				Denominator = 1;
				return;
			}

			ReduceTerms(numerator, denominator);

		}

		public void ReduceTerms(int numerator, int denominator)
		{
			var gcd = Math.Abs(numerator) < Math.Abs(denominator) ? Math.Abs(numerator) : Math.Abs(denominator);

			while (gcd >= 1)
			{
				if (numerator % gcd == 0 && denominator % gcd == 0)
				{
					Numerator = numerator / gcd;
					Denominator = denominator / gcd;
					return;
				}
				gcd--;
			}
		}

		/// <summary>
		/// Overload operator "+" for calculate sum of two rational numbers.
		/// </summary>
		/// <param name="r1"> First component. </param>
		/// <param name="r2"> Second component. </param>
		/// <returns> Sum of two rational numbers. </returns>
		public static RationalNumber operator +(RationalNumber r1, RationalNumber r2)
		{
			var numerator = r1.Numerator * r2.Denominator + r2.Numerator * r1.Denominator;
			var denominator = r1.Denominator * r2.Denominator;

			return new RationalNumber(numerator, denominator);
		}
		
		/// <summary>
		/// Overload operator "-" for calculate substraction of two rational numbers.
		/// </summary>
		/// <param name="r1"> Minuend. </param>
		/// <param name="r2"> Subtrahend. </param>
		/// <returns> Substraction of two rational numbers. </returns>
		public static RationalNumber operator -(RationalNumber r1, RationalNumber r2)
		{
			return r1 + new RationalNumber(-r2.Numerator, r2.Denominator);
		}
		
		/// <summary>
		/// Overload operator "*" for calculate multiplication of two rational numbers.
		/// </summary>
		/// <param name="r1"> First multiplier. </param>
		/// <param name="r2"> Second multiplier. </param>
		/// <returns> Multiplication of two rational numbers. </returns>
		public static RationalNumber operator *(RationalNumber r1, RationalNumber r2)
		{
			var numerator = r1.Numerator * r2.Numerator;
			var denominator = r1.Denominator * r2.Denominator;

			return new RationalNumber(numerator, denominator);
		}
		
		/// <summary>
		/// Overload operator "/" for calculate division of two rational numbers.
		/// </summary>
		/// <param name="r1"> Dividend. </param>
		/// <param name="r2"> Divider. </param>
		/// <returns> Division of two rational numbers. </returns>
		public static RationalNumber operator /(RationalNumber r1, RationalNumber r2)
		{
			return r1 * new RationalNumber(r2.Denominator, r2.Numerator);
		}

		/// <summary>
		/// Calculates absolute value of rational number.
		/// </summary>
		/// <returns> Absolute value of rational number. </returns>
		public RationalNumber Abs()
		{
			var numerator = Math.Abs(Numerator);
			var denominator = Math.Abs(Denominator);

			return new RationalNumber(numerator, denominator);
		}

		public RationalNumber Reduce()
		{
			return new RationalNumber(Numerator, Denominator);
		}

		public RationalNumber Exprational(int power)
		{
			var numerator = (int)Math.Pow(Numerator, power);
			var denominator = (int)Math.Pow(Denominator, power);

			return new RationalNumber(numerator, denominator);
		}

		public double Expreal(int baseNumber)
		{
			return baseNumber;
		}
	}
}