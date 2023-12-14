internal class Program{
	private static void Main(string[] args){
		int[] arr = new int[100];
		generateData(ref arr);
        insertSort(ref arr);
		for(int i = 1; i < arr.Length; i++) { Console.WriteLine(arr[i]); }
	}
	private static void generateData(ref int[] array)
	{
		for(int i = 0; i < 100; i++)
		{
			array[i] = i;
		}

		Random rand = new Random();

		int r;
		for(int i = 99; i > 1; i--)
		{
			r = rand.Next(1, i);
			// swap r-th & i-th element
			int tmp = array[r];
			array[r] = array[i];
			array[i] = tmp;
		}
	}
	private static void selectSort(ref int[] arr)
	{
		for(int s = 1; s < arr.Length; s++)
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
	private static void insertSort(ref int[] arr)
	{
		for(int s = 2; s < arr.Length; s++)
		{
			arr[0] = arr[s]; // zarážka
			int i = s-1;
			while (arr[0] < arr[i])
			{
				// copy i up
				arr[i+1] = arr[i];
				i--;
			}
			arr[i+1] = arr[0];
		}
	}
}