internal class Program{
	private static void Main(string[] args){
		Console.WriteLine("Převod soustav");

		int radix1, radix2;
		string input; int input10 = 0;

		while (true){
			Console.Write("Zadejte soustavu prvního čísla: ");
			try{
				radix1 = int.Parse(Console.ReadLine());
			}
			catch (Exception e){
				Console.WriteLine("Toto není číslo!");
				continue;
			}
			break;
		}

		Console.Write("Zadejte vstupní číslo: ");
		input = Console.ReadLine();

		while (true){
			Console.Write("Zadejte soustavu výsledného čísla: ");
			try{
				radix2 = int.Parse(Console.ReadLine());
			}
			catch (Exception e){
				Console.WriteLine("Toto není číslo!");
				continue;
			}
			break;
		}

		if (radix1 != 10){
			// Convert to radix 10
			for(int i = 0; i < input.Length; i++){
				int val = getValue(input[i]);
				if (val >= radix1){ Console.WriteLine("Vstup neodpovídá vstupní soustavě!"); return; }
				int pos = input.Length - i - 1;
				input10 += val * (int)Math.Pow(radix1, pos);
			}
			Console.WriteLine("In radix 10: {0}", input10);
		}else{
			try{
				input10 = int.Parse(input);
			}
			catch(Exception e){
				Console.WriteLine("Vstup není číslo!");
				return;
			}
			
		}
	}
	private static int getValue(int x){
		if(x >= 48 && x <= 57){
			return x - 48;
		}else if(x >= 65 && x <= 90){
			return x - 55;
		}else if(x >= 97 && x <= 122){
			return x - 87;
		}else{
			throw new Exception("Číslice nemá hodnotu");
		}
	}
}
