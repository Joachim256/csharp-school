internal class Program{
	private static void Main(string[] args){
		Console.WriteLine("Rozklad na součin prvočísel v1.0");
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
        Console.Write("Rozklad: {0} = ", n);

        List<int> cisla = new List<int>();

		for(int i = 2; ; i++)
		{
			while(n % i == 0)
			{
				n = n / i;
				cisla.Add(i);
			}
			if(n == 1)
			{
				break;
			}
		}

		for(int i = 0; i < cisla.Count; i++)
		{
			Console.Write("{0}", cisla[i]);
			if(i != cisla.Count - 1) { Console.Write(" * "); }
		}
		Console.WriteLine();
	}
}