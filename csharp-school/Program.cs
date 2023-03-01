internal class Program{
	private static void Main(string[] args){
		Console.WriteLine("Generátor bitů v0.1");

		int pocet = 0;
		while (pocet == 0)
		{
			try
			{
				Console.Write("Zadejte počet bitů: ");
				pocet = int.Parse(Console.ReadLine());
				if (pocet < 100) { Console.WriteLine("Prosím, alespoň 100 bitů ;)"); }
				if (pocet > 1000) { Console.WriteLine("Prosím, méně než 1000 bitů"); }
			}
			catch (Exception e) { }
		}

		byte[] bytes = new byte[pocet / 8 + 1];

		Random rng = new Random();
		rng.NextBytes(bytes);

		uint ones = 0, zeros = 0;
		bool firstbit = (bytes[0] & 1) > 0; // first bit
		int[] groups = new int[pocet];
		int gi = 0;
		if (firstbit)
		{
			groups[0] = 0;
			gi = 1;
		}
		bool last = false;

		for(int i = 0; i < bytes.Length; i++)
		{
			for(int j = 0; j < 8; j++)
			{
				if(i * 8 + j == pocet) { break; }
				bool bit = (bytes[i] & (1 << j)) > 0;
				if (bit){
					ones++;
				} else {
					zeros++;
				}
				if (bit == last) {
					groups[gi]++;
				} else {
					groups[++gi] = 1;
				}
				last = bit;
			}
		}
		Console.WriteLine();

        int onelen = 0, zerolen = 0;
		List<int> onex = new List<int>(), zerox = new List<int>();

        for (int i = 0; i < groups.Length; i++)
        {
            if (i % 2 == 0)
            {
                // 0
				if(groups[i] > zerolen)
				{
					zerolen = groups[i];
				}
            }
            else
            {
                // 1
                if (groups[i] > onelen)
                {
                    onelen = groups[i];
                }
            }
        }

		int absx = 0;
        for (int i = 0; i < groups.Length; i++)
		{
			if(i % 2 == 0){
				if (groups[i] == zerolen) {
					zerox.Add(absx);
					Console.Write("\x1b[32m");
					Console.Write(repeat("0", groups[i]));
					Console.Write("\x1b[0m");
				}
				else
				{
                    Console.Write(repeat("0", groups[i]));
                }
            }
            else {
                if (groups[i] == onelen)
                {
                    onex.Add(absx);
                    Console.Write("\x1b[31m");
                    Console.Write(repeat("1", groups[i]));
                    Console.Write("\x1b[0m");
                }
                else
                {
                    Console.Write(repeat("1", groups[i]));
                }
            }
            absx += groups[i];
        }

		Console.WriteLine("\nPočet bitů: {0}, počet jedniček: {1}, počet nul: {2}", pocet, ones, zeros);
		Console.Write("Nejdelší blok jedniček je {0} bitů dlouhý – na pozicích: ", onelen);
		foreach(int x in onex)
		{
			Console.Write("{0}, ", x);
		}
		Console.Write(".\nNejdelší blok nul je {0} bitů dlouhý – na pozicích: ", zerolen);
		foreach(int x in zerox)
		{
			Console.Write("{0}, ", x);
		}
		Console.WriteLine(".");
	}
	private static string repeat(string str, int n)
	{
		string s = "";
		for(int i = 0; i < n; i++)
		{
			s += str;
		}
		return s;
	}
}