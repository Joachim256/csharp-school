internal class Program{
	private static void Main(string[] args){
		for(int y = 1; y <= 10; y++){
			for(int x = 1; x <= 10; x++){
				int n = x * y;
				Console.Write((n < 10 ? " " : "") + n + (x == 10 ? "" : " "));
			}
			Console.WriteLine();
		}
	}
}
