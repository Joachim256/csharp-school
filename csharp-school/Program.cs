internal class Program{
	private static void Main(string[] args){
		Console.WriteLine("Jmenný seznam v0.1");

		Console.WriteLine("Zadávejte jména, která se budou řadit do abecedního seznamu. Pro ukončení zadejte @ a seznam bude vypsán.");

		string[] names = new string[26];

		while (true)
		{
			string name = Console.ReadLine();
			if(name == "@" || name == "")
			{
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
			if (names[index] != "") { names[index] += ", "; }
			names[index] += name;
		}
	}
}