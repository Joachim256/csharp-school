using System.IO;
internal class Program
{
	private static void Main(string[] args)
	{
		string prvni = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), @".\csharp-school\prvni.txt");

		CondenseFile(prvni);
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
}
