using system;
namespace Factorial
{
	class Progra,
	{
		static void main(string[] args)
		{
			int i, number,factorial;
			Console.WriteLine("Enter the number");
			number=Convert.ToInt32(Console.ReadLine());
			factorial=number;
			for(i=number-1; i>=1; i--)
				factorial*=i;
			Console.WriteLine("Factorial of the number is"+ factorial);
		}
	}
}