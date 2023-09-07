internal class Program{
	private static void Main(string[] args){
		Console.WriteLine("Stromeček v0.1");
		Console.WriteLine("Zadejte liché číslo větší než 3 a bude Vám vykreslen stromeček o zadané šířce:");

		int n;
		while (true)
		{
            string N = Console.ReadLine();
			try
			{
				n = int.Parse(N);
				if(n < 4 || n % 2 != 1)
				{
					Console.WriteLine("Zadejte prosím liché číslo větší než 3");
					continue;
				}
			} catch (Exception ex)
			{
				Console.WriteLine("Zadejte prosím číslo");
				continue;
			}
			break;
        }

		int height = n / 2 + 1;

		for(int i = 0; i < height; i++)
		{
			int stars = 1 + i * 2;
			int spaces = (n - stars) / 2;
			for(int j = 0; j < spaces; j++) { Console.Write(" "); }
			for(int j = 0; j < stars; j++) { Console.Write("*"); }
			for(int j = 0; j < spaces; j++) { Console.Write(" "); }
			Console.WriteLine();
        }
	}
}