using system;
namespace Largerthan
{
	class Program
	{
		static void main(string[] args)
		{
			int number1, number2, number3;
			number1=10;
			number2=20;
			number3=30;
			if(number1>number2)
			{
				if(number1>number3)
					Console.WriteLine("Number 1 is the largest");
				else
					Console.WriteLine("Number 3 is the largest");
			}
			else if(number2>number3)
				Console.WriteLine("Number 2 is greater");
			else
				Console.WriteLine("Number 3 is greater");
		}
	}
}