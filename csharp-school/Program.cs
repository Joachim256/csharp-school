internal class Program{
	private static void Main(string[] args){
		int[] arr = new int[100];
		generateData(ref arr);
        for (int i = 0; i < arr.Length; i++) { Console.WriteLine(arr[i]); }
		int index = binarySearch(ref arr, 55);
		Console.WriteLine($"Found on index: {index}");
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
	private static int binarySearch(ref int[] arr, int sval)
	{
		arr[0] = sval;
		int start = 1, end = arr.Length -1;

		while (start < end)
		{
			int middle = (start + end) / 2;
			if(arr[middle] == sval)
			{
				return middle;
			}
			else if (arr[middle] < sval)
			{
				start = middle + 1;
			}else if (arr[middle] > sval)
			{
				end = middle - 1;
			}
		}
		if (arr[start] == sval) { return start; }
		return -1;
	}
}
