internal class Program{
	private static void Main(string[] args){
		string? input = "";

		Console.WriteLine("Převaděč Římské číslice <-> Arabská číslice");
		Console.Write(": ");
		input = Console.ReadLine();

		char[] romanDigits = {'I', 'V', 'X', 'L', 'C', 'D', 'M'};
		HashSet<char> validRomans = new HashSet<char>(romanDigits);

		bool isArabic = false, isRoman = false;

		for(int i = 0; i < input.Length; i++){
			if(input[i] >= 48 && input[i] <= 57){
				isArabic = true;
			}else if(validRomans.Contains(input[i])){
				isRoman = true;
			}
			if(!(isArabic ^ isRoman)){
				Console.WriteLine("Neplatný vstup!");
				return;
			}
		}

		if(isArabic){
			Console.WriteLine("Arabsky: {0}\nŘímsky: {1}", input, toRoman(input));
		}else if(isRoman){
			Console.WriteLine("Římsky: {0}\nArabsky: {1}", input, toArabic(input));
		}

	}

	private static string toRoman(string str){
		string s = "";
		int num = 0;

		try{
			num = int.Parse(str);
		}catch(Exception e){
			Console.WriteLine("Neočekávaná chyba!");
			System.Environment.Exit(0);
		}
		int thousands = num / 1000;
		s += repeat("M", thousands);
		num -= thousands * 1000;
		int hundreds = num / 100;
		switch(hundreds){
			case 1:
				s += "C";
				break;
			case 2:
				s += "CC";
				break;
			case 3:
				s += "CCC";
				break;
			case 4:
				s += "CD";
				break;
			case 5:
				s += "D";
				break;
			case 6:
				s += "DC";
				break;
			case 7:
				s += "DCC";
				break;
			case 8:
				s += "DCCC";
				break;
			case 9:
				s += "CM";
				break;
		}
		num -= hundreds * 100;
		int tens = num / 10;
		switch(tens){
			case 1:
				s += "X";
				break;
			case 2:
				s += "XX";
				break;
			case 3:
				s += "XXX";
				break;
			case 4:
				s += "XL";
				break;
			case 5:
				s += "L";
				break;
			case 6:
				s += "LX";
				break;
			case 7:
				s += "LXX";
				break;
			case 8:
				s += "LXXX";
				break;
			case 9:
				s += "XC";
				break;
		}
		num -= tens * 10;
		switch(num){
			case 1:
				s += "I";
				break;
			case 2:
				s += "II";
				break;
			case 3:
				s += "III";
				break;
			case 4:
				s += "IV";
				break;
			case 5:
				s += "V";
				break;
			case 6:
				s += "VI";
				break;
			case 7:
				s += "VII";
				break;
			case 8:
				s += "VIII";
				break;
			case 9:
				s += "IX";
				break;
		}
		return s;
	}
	private static string toArabic(string str){
		return str; // todo
	}

	private static string repeat(string str, int count){
		string x = "";
		for(var i = 0; i < count; i++){
			x += str;
		}
		return x;
	}
}
