using System;

namespace Odd_and_Even
{
	class Program
	{
		public static void Main(string[] args)
		{
				do {
				Console.Clear();
				int number;
			Console.WriteLine("Input your number:");
			number= int.Parse(Console.ReadLine());
			if (number % 2 == 0)
			{
				Console.WriteLine("Number is even");
			}
			else
			{
				Console.WriteLine("Number is odd");
			}
			Console.Write("Would you like to test again? (Y= yes & N= no): ");
				}while(Console.ReadLine().ToUpper() == "Y");
				
				Console.WriteLine("Bye!");
				{
				Console.ReadKey();
				}
			}
		}
		
	}
