internal class Program{
	private static void Main(string[] args){
		Console.WriteLine("Rozklad na součin prvočísel v0.1");
		Console.WriteLine("Zadejte libovolné celé číslo (větší než 1) a bude vypsán jeho součin na prvočinitele:");

		int n;
		while (true)
		{
			string N = Console.ReadLine();
			try
			{
				n = int.Parse(N);
				if(n < 2)
				{
					Console.WriteLine("Zadejte číslo větší než 1");
					continue;
				}
			} catch
			{
				Console.WriteLine("Zadejte prosím číslo");
				continue;
			}
			break;
		}

		Console.WriteLine("Zadané číslo je {0}", n);
	}
}