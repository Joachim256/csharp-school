internal class Program{
	private static void Main(string[] args){
		int a = umocnit(3, 5);

		string s = reverse1("process.exit(1)");
		Console.WriteLine(s);
	}
	private static int umocnit(int x, int n)
	{
		if(n == 0)
		{
			return 1;
		}
		else
		{
			return x * umocnit(x, n - 1);
		}
	}
	private static string reverse(string str, int i = 0)
	{
		if(i == str.Length / 2) { return str; }
		char[] chars = str.ToCharArray();

		// swap
		chars[i] ^= chars[chars.Length - 1 - i];
		chars[chars.Length - 1 - i] ^= chars[i];
		chars[i] ^= chars[chars.Length - 1 - i];

		return reverse(new string(chars), i+1);
	}
	private static string reverse1(string str)
	{
		if(str == "") { return ""; }
		return str[str.Length - 1] + reverse1(withoutLast(str));
	}
	private static string withoutLast(string str)
	{
		char[] orig = str.ToCharArray();
		char[] shorter = new char[orig.Length - 1];
		Array.Copy(orig, shorter, orig.Length - 1);
		return new string(shorter);
	}
}