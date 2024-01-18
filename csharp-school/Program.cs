internal class Program{
	private static void Main(string[] args){
		int[] arr = new int[10];
		generateData(ref arr);
		quickSort(ref arr);
		for(int i = 0; i < arr.Length; i++) { Console.WriteLine(arr[i]); }
	}
	private static void generateData(ref int[] array)
	{
		for(int i = 0; i < 10; i++)
		{
			array[i] = i;
		}

		Random rand = new Random();

		int r;
		for(int i = 9; i > 0; i--)
		{
			r = rand.Next(0, i);
			// swap r-th & i-th element
			int tmp = array[r];
            array[r] = array[i];
			array[i] = tmp;
        }
	}
	private static void quickSort(ref int[] array) // wrapper function
	{
		quickySort(ref array, 0, array.Length -1);
	}
	private static void quickySort(ref int[] arr, int start, int end)
	{
        int pivot = arr[(start + end) / 2];
        int i = start, j = end;
		do
		{
			while (arr[i] < pivot) i++;
			while (arr[j] > pivot) j--;

			if (i <= j) {
				// swap i-th & j-th element
				int tmp = arr[i];
				arr[i] = arr[j];
				arr[j] = tmp;
				i++; j--;
			}
		} while (i < j);

        if (start < j) { quickySort(ref arr, start, j); }
		if (i < end) { quickySort(ref arr, i, end); }
	}
}