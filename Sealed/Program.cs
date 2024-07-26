class KakekNenek
{
	public string name = "Kakek dan Nenek";
}
sealed class BapakIbu : KakekNenek 
{
	public int age = 7575;
}
class Anak : BapakIbu // error karena class BapakIbu = sealed
{
	public string nama = "Anakmu";
}
class Program
{
	static void Main()
	{
		
	}
}