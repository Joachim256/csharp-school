internal class Program{
	private static void Main(string[] args){
		int n;

		while(true){
			Console.Write("Zadejte velikost motýlka (liché číslo < 25): ");
			try{
				n = int.Parse(Console.ReadLine());
			}catch(Exception e){
				Console.WriteLine("Toto není číslo!"); continue;
			}
			if(n > 25){
				Console.WriteLine("{0} je není menší než 25!"); continue;
			}
			if(n % 2 == 0){
				Console.WriteLine("{0} není liché číslo!", n); continue;
			}
			break;
		}

		int len = (n / 2 + 1) * 2;
		for(int l = 1; l <= n; l++){
			int c = (l <= n / 2 + 1) ? l : (n - l + 1);
			Console.WriteLine(repeat("*", c) + repeat(" ", len - 2*c) + repeat("*", c));
		}
	}
	private static string repeat(string str, int count){
		string x = "";
		for(var i = 0; i < count; i++){
			x += str;
		}
		return x;
	}
}