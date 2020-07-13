using system;
namespace Valueexchange
{
	class program
	{
		static void main(string[] args)
		{
			int number1, number2, temp;
			number1 = 10;
			number2 = 20;
			Console.WriteLine("Number 1:" + number1 + "Number2" + number2);
			Console.WriteLine("after exchange:");
			temp=number1;
			number1 = number2;
			number2=temp;
			Console.WriteLine("Number 1:" + number1 + "Number2" + number2);
		}
	}
}