using System.IO;
internal class Program
{
	private static void Main(string[] args)
	{
		string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), @".\csharp-school\prvni.txt");
	}
}
