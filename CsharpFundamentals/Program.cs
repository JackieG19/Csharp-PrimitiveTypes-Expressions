using System;

namespace CsharpFundamentels
{
	class Program
	{
		static void Main(string[] args)
		{
			var number = "1234";
			//int i = (int) number;
			
			byte b = Convert.ToInt32(number);
			Console.WriteLine(i);
			
			// the app will crash = System.OverflowException
			//byte b = Convert.ToByte(number);
			//Console.WriteLine(b);

		}
	}
