internal class Program{
	private static void Main(string[] args){
		Console.WriteLine("Faktoriál kalkulačka v1.0");
		Console.Write("! ");

		uint a;
		while (true)
		{
			try
			{
				a = uint.Parse(Console.ReadLine());
				break;
			}
			catch
			{
				Console.WriteLine("To není číslo!");
			}
		}

		Console.WriteLine("{0}! = {1} = {2}", a, factorial1(a), factorial2(a));
	}

	private static uint factorial1(uint n)
	{
		uint result = 1;
		for(uint i = 2; i <= n; i++)
		{
			result *= i;
		}
		return result;
	}
	private static uint factorial2(uint n)
	{
		if(n == 0)
		{
			return 1;
		}
		else
		{
			return n * factorial2(n-1);
		}
	}
}