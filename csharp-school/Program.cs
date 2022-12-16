internal class Program{
	private static void Main(string[] args){
		Console.WriteLine("Zadejte text, abyste zjistili, zda-li je to palindrom.");
		Console.Write("Zadejte text: ");
		string? input = Console.ReadLine();
		
		if(input == null){
			Console.WriteLine("Neznámá chyba");
			return;
		}

		string text = "";
		// remove spaces and unite to lowercase
		for(int i = 0; i < input.Length; i++){
			if(input[i] == 0x20){ continue; }
			text += char.ToLower(input[i]);
		}
		// check palindrome
		for(int i = 0; i < text.Length / 2; i++){
			if(text[i] != text[text.Length -i -1]){
				Console.WriteLine("Zadaný text NENÍ palindrom");
				return;
			}
		}
		Console.WriteLine("Zadaný text JE palindrom");
	}
}
