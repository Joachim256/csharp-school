internal class Program{
	private static void Main(string[] args){
		int[] arr = new int[100];
		generateData(ref arr);
		for(int i = 0; i < arr.Length; i++) { Console.WriteLine(arr[i]); }
	}
	private static void generateData(ref int[] array)
	{
		for(int i = 0; i < 100; i++)
		{
			array[i] = i;
		}

		Random rand = new Random();

		int r;
		for(int i = 99; i > 0; i--)
		{
			r = rand.Next(0, i);
			// swap r-th & i-th element
			int tmp = array[r];
            array[r] = array[i];
			array[i] = tmp;
        }
	}
}