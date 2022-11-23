internal class Program{
	private static void Main(string[] args){
		int zaklad, exp;
		int sum = 1;

        Console.WriteLine("Tento program po zadání základu mocniny a exponentu vypíše výsledek (a^n).");

        while (true) {
            try {
                Console.Write("Zadejte základ mocniny: ");
                zaklad = int.Parse(Console.ReadLine());
            } catch (Exception e) {
                Console.WriteLine("Toto není číslo!"); continue;
            }
            break;
        }
        while(true){
            try{
                Console.Write("Zadejte exponent: ");
                exp = int.Parse(Console.ReadLine());
            }catch (Exception e){
                Console.WriteLine("Toto není číslo!"); continue;
            }
            if (exp < 0){
                Console.WriteLine("Zadejte prosím kladný exponent"); continue;
            }
            break;
        }

	int i = 0;
	while(i < exp){
		sum *= zaklad;
		i++;
	}

	Console.WriteLine("Výsledek je: {0}", sum);
	Console.WriteLine("Stiskněte cokoliv pro ukončení programu...");
	Console.ReadKey();
	}
}
