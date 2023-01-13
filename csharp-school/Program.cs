internal class Program{
	private static void Main(string[] args){
		string? input = "";

		Console.WriteLine("Převaděč Římské číslice <-> Arabská číslice");
		Console.Write(": ");
		input = Console.ReadLine();
		if(input == null){Console.WriteLine("Neznámá chyba"); return;}

		if(input.ToLower() == "lidl"){ Console.WriteLine("Správná volba!"); return; }
		char[] romanDigits = {'I', 'V', 'X', 'L', 'C', 'D', 'M'};
		HashSet<char> validRomans = new HashSet<char>(romanDigits);

		bool isArabic = false, isRoman = false;

		for(int i = 0; i < input.Length; i++){
			if(input[i] >= 48 && input[i] <= 57){
				isArabic = true;
			}else if(validRomans.Contains(input[i])){
				isRoman = true;
			}else{
				isArabic = false; isRoman = false;
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
	private static string? toArabic(string str){
		Dictionary<char, int> digitValue = new Dictionary<char, int> {
			{' ', 0},
			{'I', 1},
			{'V', 5},
			{'X', 10},
			{'L', 50},
			{'C', 100},
			{'D', 500},
			{'M', 1000},
			{'.', 1001}
		};
		int[] gradeWTotal = {0, 0, 0, 0};

		int sum = 0, sub = 0;
		int sublength = 0;
		char g = str[0], highestBase = ' ';

		for(int i = 0; i < str.Length; i++){
			char c = str[i];

			if(sub == 0){
				if(digitValue[c] >= digitValue[highestBase] && highestBase != ' '){
					error(str, "Higher digit!", '^', i, 0); return null;
				}
				sub = digitValue[c];
				sublength++;
			}else{
				if(g == c){
					sub += digitValue[c];
					sublength++;
				}else if(digitValue[g] > digitValue[c]){
					int[] grd = grades(sub / sublength);
					for(int j = 0; j < 4; j++){
						gradeWTotal[j] += grd[j]*sublength;
						if(gradeWTotal[j] >= 10){
							error(str, "Going over digit!", '^', i-1, 0); return null;
						}
					}
					sum += sub;
					sub = digitValue[c];
					sublength = 1;
					if(digitValue[c] >= digitValue[highestBase] && highestBase != ' '){
						error(str, "Higher digit!", '^', i, 0); return null;
					}
					highestBase = g;
				}else if(digitValue[g] < digitValue[c]){
					if(digitValue[c] >= digitValue[highestBase] && highestBase != ' '){
						error(str, "Higher digit!", '^', i, 0); return null;
					}
					highestBase = c;
					
					if(digitValue[c] - sub <= 0){
						error(str, "Subtracting too much!", '/', i, sublength); return null;
					}

					int[] grd = grades((digitValue[c] - sub) / sublength);
					for(int j = 0; j < 4; j++){
						gradeWTotal[j] += grd[j]*sublength;
						if(gradeWTotal[j] >= 10){
							error(str, "Going over digit!", '^', i, 0); return null;
						}
					}
					
					sum += digitValue[c] - sub;
					sub = 0;
					sublength = 0;
				}
			}
			// sublength > 1 warn
			
			g = c;
		}

		if(sub > 0){
			int[] grd1 = grades(sub / sublength);
			for(int j = 0; j < 4; j++){
				gradeWTotal[j] += grd1[j]*sublength;
				if(gradeWTotal[j] >= 10){
					error(str, "Going over digit!", '^', str.Length -1, 0); return null;
				}
			}
		}
		sum += sub;
		return sum.ToString();
	}
	private static void error(string n, string text, char type, int pos, int len){
		msg('e', n, text, type, pos, len);
	}
	private static void warn(string n, string text, char type, int pos, int len){
		msg('w', n, text, type, pos, len);
	}
	private static void msg(char t, string n, string text, char type, int pos, int len){
		// print number
		Console.WriteLine("\t{0}", n);
		// begin color
		if(t == 'e'){
			Console.Write("\x1b[31m");
		}else if(t == 'w'){
			Console.Write("\x1b[33m");
		}
		// print arrows
		if(type == '^'){
			Console.WriteLine("\t{0}^", repeat(" ", pos));
		}else if(type == '/'){
			Console.WriteLine("\t{0}{1}^", repeat(" ", pos-len), repeat("-", len));
		}
		// print text
		Console.WriteLine("\t{0}\x1b[0m", text);
	}
	private static int[] grades(int num){
		int[] arr = {0, 0, 0, 0};
		int tmp;
		for(int i = 3; i >= 0; i--){
			tmp = num / (int)Math.Pow(10, i);
			arr[i] = tmp;
			num -= tmp * (int)Math.Pow(10, i);
		}
		return arr;
	}

	private static string repeat(string str, int count){
		string x = "";
		for(var i = 0; i < count; i++){
			x += str;
		}
		return x;
	}
}
