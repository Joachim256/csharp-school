internal class Program{
	private static void Main(string[] args){
		Console.WriteLine("Aplikace Průměr známek v1.0");
		int pocet = 0;
		while (pocet == 0)
		{
			try
			{
                Console.Write("Zadejte počet známek: ");
                pocet = int.Parse(Console.ReadLine());
				if (pocet == 0) { Console.WriteLine("Prosím, alespoň jednu známku ;)"); }
			}
			catch(Exception e){}
		}
		uint[] znamky = new uint[pocet];
		for(int i = 0; i < pocet; i++)
		{
            while (true)
            {
                Console.Write("\nZadejte známku (č. {0}): ", i + 1);
				char z = Console.ReadKey().KeyChar;
				znamky[i] = (uint)(z - 0x30);
				if(z > 0x30 && z <= 0x35) { break; }
            }
        }
		Console.WriteLine();
		Console.WriteLine("Zadali jste známky: {0}", String.Join("; ", znamky));
		uint suma = 0;
		for (int i = 0; i < pocet; i++)
		{
			suma += znamky[i];
		}
		float avg = (float)suma / pocet;
		Console.WriteLine("Váš průměr je: {0}", avg);
		Console.WriteLine("Nejlepší známka: {0}", znamky.Min());
		Console.WriteLine("Nejhorší známka: {0}", znamky.Max());
	}
}