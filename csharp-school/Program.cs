internal class Program{
	private static void Main(string[] args){
		string? input = "";

		Console.WriteLine("Převaděč Římské číslice <-> Arabská číslice");
		Console.Write(": ");
		input = Console.ReadLine();

		char[] romanDigits = {'I', 'V', 'X', 'L', 'C', 'D', 'M'};
		HashSet<char> validRomans = new HashSet<char>(romanDigits);

		bool isArabic, isRoman;

		for(int i = 0; i < input.Length; i++){
			if(input >= 48 && input <= 57){
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
		string out = "";
		int num;

		try{
			num = int.Parse(str);
		}catch(Exception e){
			Console.WriteLine("Neočekávaná chyba!");
			System.Environment.Exit(0);
		}
		int thousands = num / 1000;
		out += repeat("M", thousands);
		num -= thousands * 1000;
		int hundreds = num / 100;
		switch(hundreds){
			case 1:
				out += "C";
				break;
			case 2:
				out += "CC";
				break;
			case 3:
				out += "CCC";
				break;
			case 4:
				out += "CD";
				break;
			case 5:
				out += "D";
				break;
			case 6:
				out += "DC";
				break;
			case 7:
				out += "DCC";
				break;
			case 8:
				out += "DCCC";
				break;
			case 9:
				out += "CM";
				break;
		}
		num -= hundreds * 100;
		int tens = num / 10;
		switch(tens){
			case 1:
				out += "X";
				break;
			case 2:
				out += "XX";
				break;
			case 3:
				out += "XXX";
				break;
			case 4:
				out += "XL";
				break;
			case 5:
				out += "L";
				break;
			case 6:
				out += "LX";
				break;
			case 7:
				out += "LXX";
				break;
			case 8:
				out += "LXXX";
				break;
			case 9:
				out += "XC";
				break;
		}
		num -= tens * 10;
		switch(num){
			case 1:
				out += "I";
				break;
			case 2:
				out += "II";
				break;
			case 3:
				out += "III";
				break;
			case 4:
				out += "IV";
				break;
			case 5:
				out += "V";
				break;
			case 6:
				out += "VI";
				break;
			case 7:
				out += "VII";
				break;
			case 8:
				out += "VIII";
				break;
			case 9:
				out += "IX";
				break;
		}
		return out;
	}
	private static string toArabic(string str){

	}

	private static string repeat(string str, int count){
		string x = "";
		for(var i = 0; i < count; i++){
			x += str;
		}
		return x;
	}
}
