internal class Program{
	private static void Main(string[] args){
		Console.WriteLine("Textová sčítačka v0.1");
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