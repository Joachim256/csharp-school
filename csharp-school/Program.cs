internal class Program{
	private static void Main(string[] args){
		int a, b;
		Console.WriteLine("Implementace Euklidova odečítacího a dělícího algoritmu pro nalezení největšího společného dělitele");

		while(true){
			Console.Write("Zadejte první číslo: ");
			try{
				a = int.Parse(Console.ReadLine());
			}catch(Exception e){
				Console.WriteLine("Toto není číslo!"); continue;
			}
			break;
		}
		while(true){
			Console.Write("Zadejte druhé číslo: ");
			try{
				b = int.Parse(Console.ReadLine());
			}catch(Exception e){
				Console.WriteLine("Toto není číslo!"); continue;
			}
			break;
		}

		Console.WriteLine("Největší společný dělitel zadaných čísel spočítaný:\nEuklidovým odčítacím algoritmem: {0}\nEuklidovým dělícím algoritmem: {1}", SubEuclid(a,b), DivEuclid(a,b));
	}
	// Euklidův odčítací algoritmus
	private static int SubEuclid(int u, int w){
		while(u != w){
			if(u > w){
				u = u - w;
			}else{
				w = w - u;
			}
		}
		return u;
	}
	// Euklidův dělící algoritmus
	private static int DivEuclid(int u, int w){
		int r;
		if(u < w){
			// xor swap
			u = u ^ w;
			w = w ^ u;
			u = u ^ w;
		}
		while(w != 0){
			r = u % w;
			u = w;
			w = r;
		}
		return u;
	}
}