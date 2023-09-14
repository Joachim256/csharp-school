internal class Program{
	private static void Main(string[] args){
		Console.Write("Zadejte základní cenu: ");
		string zaklad = Console.ReadLine();
		Console.Write("Zadejte zdražení v procentech: ");
		string zdrazeni = Console.ReadLine();
		zdrazeni = zdrazeni.Replace("%", "");

		double cena, procent;
		try
		{
			cena = double.Parse(zaklad);
			procent = double.Parse(zdrazeni);
		}
		catch
		{
			Console.WriteLine("Zadané hodnoty nejsou čísla!");
			return;
		}
		Console.WriteLine("Zdražení pomocí funkce: {0}", ZdrazitFunkce(cena, procent / 100));
		ZdrazitProcedura(ref cena, procent / 100);
		Console.WriteLine("Zdražení pomocí procedury: {0}", cena);
	}
	private static double ZdrazitFunkce(double cena, double zdrazeni)
	{
		return (zdrazeni + 1) * cena;
	}
	private static void ZdrazitProcedura(ref double cena, double zdrazeni)
	{
		cena *= zdrazeni + 1;
	}
}
