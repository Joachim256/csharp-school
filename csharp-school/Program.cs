internal class Program{
	private static void Main(string[] args){
		string? choice;
		string? input;
		string output = "";
		int key;
		char act;

		Console.WriteLine("Caesarovův šifrátor");

		while(true){
			Console.Write("Chcete šifrovat nebo dešifrovat? (š/d): ");
			choice = Console.ReadLine();
			if(choice == null){Console.WriteLine("Neznámá chyba"); return;}
			if(choice.ToLower() == "lidl"){ Console.WriteLine("Správná volba!"); continue; }
			if(choice.Length != 1){ continue; }
			act = choice[0];
			if(choice[0] != 'š' && choice[0] != 'd'){ continue; }
			break;
		}

		if(act == 'š'){
			Console.WriteLine("Zadejte text pro zašifrování:");
		}else{
			Console.WriteLine("Zadejte text pro dešifrování:");
		}

		input = Console.ReadLine();
		if(input == null){Console.WriteLine("Neznámá chyba"); return;}

		while(true){
			Console.Write("Zadejte klíč: ");
			try{
				key = int.Parse(Console.ReadLine());
			}catch(Exception e){
				Console.WriteLine("Klíč musí být číslo!");
				continue;
			}
			break;
		}
		
		// key = key % 27;
		if(act == 'd'){key = -key;}

		// adjust string
		System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
		input = System.Text.Encoding.UTF8.GetString(System.Text.Encoding.GetEncoding("ISO-8859-8").GetBytes(input));
		input = input.ToUpper();

		for(int i = 0; i < input.Length; i++){
			char l = (char)(input[0] + key);
			if(l > 90){
				l = (char)(65 + l - 90 -1);
			}else if(l < 65){
				l = (char)(l - 65 + 90 +1);
			}
			output += l;
		}

	}
}
