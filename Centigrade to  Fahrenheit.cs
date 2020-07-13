using system;
namespace CtoF
{
	class Program
	{
		static void main(string[] args)
		{
			double fahrenheit;
			Console.WriteLine("Enter the Centrigrade value");
			double centigrade=Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Centigrade:"+ centigrade);
			fahrenheit = (centigrade*9)/5+32;
			Console.WriteLine("Fahrenheit:"+ fahrenheit);
		}
	}
}
