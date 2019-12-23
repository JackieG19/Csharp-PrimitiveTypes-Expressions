using System;

namespace CsharpFundamentels
{
	class Program
	{
		static void Main(string[] args)
		{
			byte b = 1;
			int i = b;
			Console.WriteLine(i);
			
			int i = 1000;
			byte b = (byte) i;
			Console.WriteLine(b);
		}
	}
