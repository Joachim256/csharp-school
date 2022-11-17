internal class Program{
	private static void Main(string[] args){
		int prvniCislo = 0;
		int druheCislo = 0;
		int tretiCislo = 0;
		
		Console.WriteLine("Tento program po zadání tří čísel vypíše zadaná čísla seřazena od největšího po nejmenší.");

		try{
			Console.Write("Zadejte první číslo: ");
			prvniCislo = int.Parse(Console.ReadLine());
			Console.Write("Zadejte druhé číslo: ");
			druheCislo = int.Parse(Console.ReadLine());
			Console.Write("Zadejte třetí číslo: ");
			tretiCislo = int.Parse(Console.ReadLine());
		}catch(Exception e){
			Console.WriteLine("Toto není číslo!");
			return;
		}
		
		int[] input = {prvniCislo, druheCislo, tretiCislo};
		int[] output = new int[3];

		for (int i = 0; i < 3; i++){
			int nejvetsi = int.MinValue;
			int nejvetsiIndex;
			for (int j = 0; j < 3; j++){
				if (input[j] > nejvetsi){
					nejvetsi = input[j];
					nejvetsiIndex = j;
				}
			}
			output[i] = nejvetsi;
			input[nejvetsiIndex] = int.MinValue;
		}

		Console.WriteLine("Čísla v pořadí od největší po nejmenší jsou: {0}, {1}, {2}", output[0], output[1], output[2]);
	}
}
