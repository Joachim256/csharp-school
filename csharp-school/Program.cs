internal class Program{
	private static void Main(string[] args){
		int cislo;

		Console.WriteLine("Tento program po zadání čísla vypíše malou násobilku pro dané číslo.");

		try{
			Console.Write("Zadejte číslo od 2 do 10: ");
			cislo = int.Parse(Console.ReadLine());
		}catch (Exception e){
			Console.WriteLine("Toto není číslo!\nStikněte cokoliv pro ukončení programu...");
			Console.ReadKey();
			return;
		}

		if (cislo < 2 || cislo > 10){
			Console.WriteLine("Číslo není v rozmezí 2–10!\nStikněte cokoliv pro ukončení programu...");
			Console.ReadKey();
			return;
		}

		for (int i = 1; i <= 10; i++){
			int vysledek = i * cislo;
			Console.WriteLine("{0} × {1} = {2}", i, cislo, vysledek);
		}

		Console.WriteLine("Pro ukončení programu stikněte cokoliv...");
		Console.ReadKey();
	}
}