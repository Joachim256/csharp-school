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
	// Euklidův dělící algoritmus
	private static int DivEuclid(int u, int w){
		int r;
		if(u < w){
			// xor swap
			u = u ^ w;
			w = w ^ u;
			u = u ^ w;
		}
		while(w != 0){
			r = u % w;
			u = w;
			w = r;
		}
		return u;
	}
}