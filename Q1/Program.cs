using System;

namespace Q1
{
	public static class IntExtensions
	{
		public static bool IsEven(this int source)
		{
			return source % 2 == 0;
		}

		public static bool IsOdd(this int source)
		{
			return source % 2 == 1;
		}
	}

	public static class StringExtensions
	{
		public static string Left(this string value, int length)
		{
			if (string.IsNullOrEmpty(value)) return string.Empty;
			if (length <= 0) return string.Empty;
			if (value.Length <= length) return value;

			return value.Substring(0, length);
		}

		public static int ToInt(this string value, int defaultValue)
		{
			bool isInt = int.TryParse(value, out int num);
			return isInt ? num : defaultValue;
		}
	}

	internal class Program
	{
		private static void Main(string[] args)
		{
			bool result = 99.IsEven();
			bool result2 = 99.IsOdd();

			string str = "abcdefghijklmn";
			string result3 = str.Left(5);
			Console.WriteLine(result3);

			string str2 = "123";
			int result4 = str2.ToInt(0);
			Console.WriteLine(result4);
		}
	}
}