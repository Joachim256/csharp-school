internal class Program{
	private static void Main(string[] args){
		Console.WriteLine("Textová sčítačka v0.1");

		Console.WriteLine("Napište libovolnou větu obsahující čísla a zjistíte součet všech:");
		string str = Console.ReadLine();
		List<int> numbers = ExtractNumbers(str);
		int sum = Sum(numbers);

		string output = "";
		for(int i = 0; i < numbers.Count; i++)
		{
			output += numbers[i];
			if (i < numbers.Count -1)
			{
				output += " + ";
			}
		}
		output += " = " + sum;
		Console.WriteLine(output);
	}
	private static List<int> ExtractNumbers(string input)
	{
		var numbers = new List<int>();
		string num = "";

		foreach(char a in input)
		{
			if(a >= 0x30 && a <= 0x39)
			{
				// it's a number character
				num += a;
			}
			else
			{
				if(num.Length == 0){ continue; }
				numbers.Add(int.Parse(num));
				num = "";
			}
		}
		if(num.Length > 0)
		{
            numbers.Add(int.Parse(num));
        }

		return numbers;
	}
	private static int Sum(List<int> numbers)
	{
		int sum = 0;
		foreach(int n in numbers)
		{
			sum += n;
		}
		return sum;
	}
}
