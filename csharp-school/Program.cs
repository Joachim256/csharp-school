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

		if(prvniCislo < druheCislo){
			// vymenit prvniCislo a druheCislo
			prvniCislo = prvniCislo ^ druheCislo;
			druheCislo = druheCislo ^ prvniCislo;
			prvniCislo = prvniCislo ^ druheCislo;
		}
		if(druheCislo < tretiCislo){
			// vymenit druheCislo a prvniCislo
			druheCislo = druheCislo ^ tretiCislo;
			tretiCislo = tretiCislo ^ druheCislo;
			druheCislo = druheCislo ^ tretiCislo;
		}
		if(prvniCislo < druheCislo){
			// vymenit prvniCislo a druheCislo
			prvniCislo = prvniCislo ^ druheCislo;
			druheCislo = druheCislo ^ prvniCislo;
			prvniCislo = prvniCislo ^ druheCislo;
		}

		Console.WriteLine("Čísla v pořadí od největší po nejmenší jsou: {0}, {1}, {2}", output[0], output[1], output[2]);
		Console.WriteLine("Pro ukončení programu zmáčkněte cokoliv...");
		Console.ReadKey();
	}
}
