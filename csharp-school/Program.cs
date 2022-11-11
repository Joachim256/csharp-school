internal class Program{
	private static void Main(string[] args){
		int prvniCislo = 0;
		int druheCislo = 0;
		int tretiCislo = 0;

		try{
			Console.Write("Zadejte první číslo:");
			prvniCislo = int.Parse(Console.ReadLine());
			Console.Write("Zadejte druhé číslo:");
			druheCislo = int.Parse(Console.ReadLine());
			Console.Write("Zadejte třetí číslo:");
			tretiCislo = int.Parse(Console.ReadLine());
		}catch(Exeption e){
			Console.WriteLine("Toto není číslo!");
			return;
		}

	}
}
