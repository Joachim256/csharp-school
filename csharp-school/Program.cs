using System.IO;
internal class Program
{
	private static void Main(string[] args)
	{
		string prvni = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), @".\csharp-school\prvni.txt");
		string pribeh = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), @".\csharp-school\pribeh.txt");

        CondenseFile(prvni);
		SummarizeFile(pribeh);
	}
	private static void CondenseFile(string path)
	{
        string str = "";
        using (var f = new StreamReader(path))
		{
			string line;
			while ((line = f.ReadLine()) != null)
			{
				str += " " + line;
			}
			f.Close();
		};
		using (var f = new StreamWriter(path))
		{
			f.WriteLine(str);
		}
	}
	private static void SummarizeFile(string path)
	{
		var f = new StreamReader(path);
		string text = f.ReadToEnd();
		f.Close();

		string[] words = text.Split(new char[] { ' ' });
		int letters = 0;
		foreach (var word in words)
		{
			letters += word.Length;
		}

		using (var f2 = new StreamWriter(path, true))
		{
			f2.WriteLine("\nSoubor obsahuje:\n" + words.Length.ToString() + " slov\n" + letters + " písmen");
		}
	}
}
