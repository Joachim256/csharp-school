internal class Program{
	private static void Main(string[] args){
		Console.WriteLine("Kalkulačka 1.0");

		int c1, c2;
		string op;

		while (true){
			Console.Write("Zadejte první číslo: ");
			try{
				c1 = int.Parse(Console.ReadLine());
			}
			catch (Exception e){
				Console.WriteLine("Toto není číslo!");
				continue;
			}
			break;
		}
		while (true){
			Console.Write("Zadejte operaci (+ - * /): ");
			op = Console.ReadLine();

			if(op != "+" && op != "-" && op != "*" && op != "/"){
				Console.WriteLine("Neplatná operace!");
				continue;
			}
			break;
		}
		while (true){
			Console.Write("Zadejte druhé číslo: ");
			try{
				c2 = int.Parse(Console.ReadLine());
			}
			catch (Exception e){
				Console.WriteLine("Toto není číslo!");
				continue;
			}
			break;
		}

		float vysledek = 0;
		if(op == "+"){
			vysledek = c1 + c2;
		}else if(op == "-"){
			vysledek = c1 - c2;
		}else if(op == "*"){
			vysledek = c1 * c2;
		}else if(op == "/"){
			vysledek = (float)c1 / (float)c2;
		}

		Console.WriteLine("Výsledek je {0}", vysledek);
	}
}
