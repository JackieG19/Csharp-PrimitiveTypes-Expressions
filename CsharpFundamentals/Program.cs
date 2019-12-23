using System;

namespace CsharpFundamentels
{
	class Program
	{
		static void Main(string[] args)
		{
// 			byte b = 1;
// 			int i = b;
// 			Console.WriteLine(i);
			
// 			int i = 1000;
// 			byte b = (byte) i;
// 			Console.WriteLine(b);
			
			var number = "1234";
			//int i = (int) number;
			
			byte b = Convert.ToInt32(number);
			Console.WriteLine(i);
			
			// the app will crash = System.OverflowException
			// byte b = Convert.ToByte(number);
			// Console.WriteLine(b);
		}
	}
