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

		Console.WriteLine("číslo je {0}", n);
	}
}