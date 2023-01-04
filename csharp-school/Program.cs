internal class Program{
	private static void Main(string[] args){
		
	}
	// Euklidův odčítací algoritmus
	private static int SubEuclid(int u, int w){
		while(u != w){
			if(u > w){
				u = u - w;
			}else{
				w = w - u;
			}
		}
		return u;
	}
}