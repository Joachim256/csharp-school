internal class Program{
	private static void Main(string[] args){
		Console.Write("Zadejte smajlík: ");
		String? smajlik = Console.ReadLine();

		if (smajlik == null) {
			Console.WriteLine("Neznámá chyba");
		}

		switch(smajlik){
			case ":-)":
				Console.WriteLine("Smajlík je veselý");
				break;
			case ":)":
				Console.WriteLine("Smajlík je veselý");
				break;
			case ":-(":
				Console.WriteLine("Smajlík je smutný");
				break;
			case ":(":
				Console.WriteLine("Smajlík je smutný");
				break;
			case ":-*":
				Console.WriteLine("Smajlík je zamilovaný");
				break;
			case ":-P":
				Console.WriteLine("Smajlík má vyplazený jazyk");
				break;
			default:
				Console.WriteLine("Neznámý smajlík");
				break;
		}
	}
}