using system;
namespace Sumofdigits
{
	class Program
	{
		static void main(string[] args)
		{
			int number, sum=0;
			Console.WriteLine("Enter the number");
			Number=Convert.ToInt32(Console.ReadLine());
			while(number>0)
			{
				sum+=(number%10);
				number/=10;
			}
			Console.WriteLine("The sum is"+ sum);
		}
	}
}