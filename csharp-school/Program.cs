internal class Program{
	private static void Main(string[] args){
		string? choice;
		string? input;
		string output = "";
		string? key;
		char act;

		Console.WriteLine("Polyalfabetický šifrátor");

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

		Console.Write("Zadejte klíč: ");
		key = Console.ReadLine();
		if(key == null){Console.WriteLine("Neznámá chyba"); return;}

		// adjust strings
		System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
		input = System.Text.Encoding.UTF8.GetString(System.Text.Encoding.GetEncoding("ISO-8859-8").GetBytes(input));
		input = input.ToUpper();
		key = System.Text.Encoding.UTF8.GetString(System.Text.Encoding.GetEncoding("ISO-8859-8").GetBytes(key));
		key = key.ToUpper();

		string tmp = "";
		for(int i = 0; i < key.Length; i++){
			if(key[i] == ' '){ continue; }
			if(key[i] < 65 || key[i] > 90){
				Console.WriteLine("Klíč obsahuje nepovolené znaky!"); return;
			}
			tmp += key[i];
		}
		key = tmp;

		int sign = (act == 'š') ? 1 : -1;

		for(int i = 0; i < input.Length; i++){
			char k = (char)(key[i % key.Length] - 64);
			char l;
			if(input[i] < 65 || input[i] > 90){
				l = input[i];
			}else{
				l = (char)(input[i] + k * sign);
				if(l > 90){
					l = (char)(65 + l - 90 -1);
				}else if(l < 65){
					l = (char)(l - 65 + 90 +1);
				}
			}
			output += l;
		}

		if(act == 'š'){
			Console.WriteLine("Zašifrovaný text: {0}", output);
		}else{
			Console.WriteLine("Dešifrovaný text: {0}", output);
		}
	}
}
