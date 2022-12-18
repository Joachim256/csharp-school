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
		char[] ignoredCharacters = {' ', '.', ',', ';', '?', '!', '\'', '"', ':', '-', '+', '(', ')'};
		HashSet<char> ignoredChars = new HashSet<char>(ignoredCharacters);
		// remove spaces and unite to lowercase
		for(int i = 0; i < input.Length; i++){
			if(ignoredChars.Contains(input[i])){ continue; }
			text += char.ToLower(input[i]);
		}
		// check palindrome
		if(isPalindrome(text)){
			Console.WriteLine("Zadaný text JE palindrom");
		}else{
			// register encoding provider or something
			// https://github.com/dotnet/runtime/issues/22907#issuecomment-317792540
			System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
			// remove diacritics
			// https://stackoverflow.com/a/2086575/11586320
			string nodiac = System.Text.Encoding.UTF8.GetString(System.Text.Encoding.GetEncoding("ISO-8859-8").GetBytes(text));
			if(isPalindrome(nodiac)){
				Console.WriteLine("Zadaný text JE BEZ OHLEDU NA DIAKRITIKU palindrom");
			}else{
				Console.WriteLine("Zadaný text NENÍ palindrom");
			}
		}
	}
	private static bool isPalindrome(string text){
		for(int i = 0; i < text.Length / 2; i++){
			if(text[i] != text[text.Length -i -1]){
				return false;
			}
		}
		return true;
	}
}
