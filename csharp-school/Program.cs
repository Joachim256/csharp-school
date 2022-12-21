internal class Program{
	private static void Main(string[] args){
		string? choice;
		string? input;
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

		
		
	}
}