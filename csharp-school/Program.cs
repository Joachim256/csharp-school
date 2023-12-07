internal class Program{
	private static void Main(string[] args){
		int[] arr = new int[100];
		generateData(ref arr);
        selectSort(ref arr);
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
	private static void selectSort(ref int[] arr)
	{
		for(int s = 0; s < arr.Length; s++)
		{
			int min = s;
			for(int i = s; i < arr.Length; i++)
			{
				if (arr[i] < arr[min]) { min = i; }
			}
			// swap s & min
			int tmp = arr[min];
			arr[min] = arr[s];
			arr[s] = tmp;
        }
	}
}