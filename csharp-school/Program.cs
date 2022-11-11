internal class Program{
	private static void Main(string[] args){
		int prvniCislo = 0;
		int druheCislo = 0;
		int tretiCislo = 0;

		Console.WriteLine("Tento program po zadání tří čísel vypíše, které je největší.");

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

		if(prvniCislo > druheCislo){
			if(prvniCislo > tretiCislo){
				Console.WriteLine("Číslo {0} je největší", prvniCislo);
			}else{
				Console.WriteLine("Číslo {0} je největší", tretiCislo);
			}
		}else{
			if(druheCislo > tretiCislo){
				Console.WriteLine("Číslo {0} je největší", druheCislo);
			}else{
				Console.WriteLine("Číslo {0} je největší", tretiCislo);
			}
		}
	}
}
