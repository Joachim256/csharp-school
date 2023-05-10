internal class Program{
	private static void Main(string[] args){
		Console.WriteLine("Jmenný seznam v1.0");

		Console.WriteLine("Zadávejte jména, která se budou řadit do abecedního seznamu. Pro ukončení zadejte @ a seznam bude vypsán.");

		string[] names = new string[26];
		int[] counts = new int[26];

		while (true)
		{
			string name = Console.ReadLine();
			if(name == "@" || name == "")
			{
				for(int i = 0; i < 26; i++)
				{
					if (counts[i] == 0) { continue; }
					Console.WriteLine("({0}) {1}", counts[i], names[i]);
				}
				break;
			}
			if (name[0] >= 97 && name[0] <= 122)
			{
				char[] charstr = name.ToCharArray();
				charstr[0] -= (char)32;
				name = new string(charstr);
			}else if (name[0] < 65 || name[0] > 90)
			{
				Console.WriteLine("To nevypadá jako jméno!");
				continue;
			}

			int index = name[0] - 65;
			if (counts[index] != 0) { names[index] += ", "; }
			names[index] += name;
			counts[index]++;
		}
	}
}