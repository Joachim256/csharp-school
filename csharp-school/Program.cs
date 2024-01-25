internal class Program{
	private static void Main(string[] args){
		int[] arr = new int[100];
		generateData(ref arr);
        for (int i = 0; i < arr.Length; i++) { Console.WriteLine(arr[i]); }
    }
	private static void generateData(ref int[] arr)
	{
		var rng = new Random();
		arr[0] = 0;
		for(int i = 1; i < arr.Length; i++)
		{
			arr[i] = arr[i-1] + rng.Next(10);
		}
	}

}