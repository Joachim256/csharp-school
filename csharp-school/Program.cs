internal class Program{
	private static void Main(string[] args){
		string jmeno = "";
		int vek = 0;
		int vaha = 0;
		int vyska = 0;
		
		try{
			Console.Write("Zadejte jméno: ");
			jmeno = Console.ReadLine();
			Console.Write("Zadejte věk: ");
			vek = int.Parse(Console.ReadLine());
			Console.Write("Zadejte váhu (v kg): ");
			vaha = int.Parse(Console.ReadLine());
			Console.Write("Zadejte výšku (v cm): ");
			vyska = int.Parse(Console.ReadLine());
		}
		catch (Exception e){
			Console.WriteLine("Toto není číslo!");
			return;
		}

		Console.WriteLine(jmeno + " již měl " + vek + ". narozeniny, ");
		Console.WriteLine("váží " + vaha + " kg a měří " + vyska + " cm. ");
		Console.WriteLine();

        // Console.WriteLine(jmeno + " již měl " + vek + ". narozeniny, \nváží " + vaha + " kg a měří " + vyska + " cm. \n");
		Console.WriteLine("{0} má {1} let, \nváží {2} kg a měří {3} cm.", jmeno, vek, vaha, vyska);
	}
}