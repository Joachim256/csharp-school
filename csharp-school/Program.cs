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
		Console.WriteLine("Zadali jste známky: {0}\n", String.Join("; ", znamky));
		uint suma = 0;
		uint nejlepsi = 6; uint nejlepsiIndex = 0;
		uint nejhorsi = 0; uint nejhorsiIndex = 0;
		for (uint i = 0; i < pocet; i++)
		{
			suma += znamky[i];
			if (znamky[i] < nejlepsi)
			{
				nejlepsi = znamky[i];
				nejlepsiIndex = i;
			}
			if (znamky[i] > nejhorsi)
			{
				nejhorsi = znamky[i];
				nejhorsiIndex = i;
			}
		}
		float avg = (float)suma / pocet;
		Console.WriteLine("Váš průměr je: {0}", avg);
		Console.WriteLine("Nejlepší známka: {0} (č. {1})", nejlepsi, nejlepsiIndex + 1);
		Console.WriteLine("Nejhorší známka: {0} (č. {1})", nejhorsi, nejhorsiIndex + 1);
	}
}
