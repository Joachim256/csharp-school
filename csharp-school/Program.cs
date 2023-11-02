using System.IO;
internal class Program
{
	private static void Main(string[] args)
	{
		string prvni = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), @".\csharp-school\prvni.txt");
		string pribeh = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), @".\csharp-school\pribeh.txt");
		string serad = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), @".\csharp-school\serad.txt");
		string serazeno = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), @".\csharp-school\serazeno.txt");

		CondenseFile(prvni);
		SummarizeFile(pribeh);
		SortSentence(serad, serazeno);
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
	private static void SortSentence(string readPath, string writePath)
	{
		var f = new StreamReader(readPath);
		string text = f.ReadToEnd();
		f.Close();

		string[] words = text.Split(new char[] {' '});
		words = words.Where(x => x != "\r\n").ToArray();
		string[] sortedWords = new string[words.Length];

		for(int w = 0; w < words.Length; w++)
		{
			string lowest = words[0];
			int lowestIndex = 0;
			for (int i = 0; i < words.Length; i++)
			{
				string str = words[i];
				if(str == "") { continue; }

				for (int j = 0; j < Math.Max(str.Length, lowest.Length); j++)
				{
					if(j >= Math.Min(str.Length, lowest.Length) || str.ToLower()[j] < lowest.ToLower()[j])
					{
						lowestIndex = i;
						lowest = words[i];
						break;
					}
					else if (str.ToLower()[j] > lowest.ToLower()[j])
					{
						break;
					}
				}
			}
			sortedWords[w] = words[lowestIndex];
			words[lowestIndex] = "";
		}

		using (var f2 = new StreamWriter(writePath, false))
		{
			f2.WriteLine(string.Join("\n", sortedWords));
		}
	}
}
