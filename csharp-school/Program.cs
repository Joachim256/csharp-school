internal class Program{
	private static void Main(string[] args){
		int prvniCislo = 0;
		int druheCislo = 0;
		int tretiCislo = 0;

		Console.WriteLine("Tento program po zadání tří čísel vypíše jejich součet, rozdíl, součin a podíl.");

		try{
			Console.Write("Zadejte první číslo: ");
			prvniCislo = int.Parse(Console.ReadLine());
			Console.Write("Zadejte druhé číslo: ");
			druheCislo = int.Parse(Console.ReadLine());
			Console.Write("Zadejte třetí číslo: ");
			tretiCislo = int.Parse(Console.ReadLine());
		}catch (Exception e){
			Console.WriteLine("Toto není číslo!");
			return;
		}

		Console.WriteLine("Součet pro tři zadaná čísla {0}, {1} a {2} je: {0} + {1} + {2} = {3}", prvniCislo, druheCislo, tretiCislo, prvniCislo+druheCislo+tretiCislo);
		Console.WriteLine("Rozdíl pro tři zadaná čísla {0}, {1} a {2} je: {0} - {1} - {2} = {3}", prvniCislo, druheCislo, tretiCislo, prvniCislo-druheCislo-tretiCislo);
		Console.WriteLine("Součin pro tři zadaná čísla {0}, {1} a {2} je: {0} × {1} × {2} = {3}", prvniCislo, druheCislo, tretiCislo, prvniCislo*druheCislo*tretiCislo);
		Console.WriteLine("Podíl pro tři zadaná čísla {0}, {1} a {2} je: {0} ÷ {1} ÷ {2} = {3}", prvniCislo, druheCislo, tretiCislo, (float)prvniCislo/(float)druheCislo/(float)tretiCislo);

        Console.Write("Stiskněte libovolnou klávesu pro ukončení programu...");
        Console.ReadKey();
    }
}