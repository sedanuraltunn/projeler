using System.Reflection.PortableExecutable;

namespace CtorDemo;

internal class Kategori
{
	//public Kategori()
	//{
	//	Console.WriteLine("ctor");
	//	Id= Guid.NewGuid();
	//	Adi = "Gıda";
	//	Aciklama = "Gıda kategorisi";
	//}

	public Kategori(string adi)
	{
		Adi = adi;
	}

	~Kategori() 
	{
	}
	public Guid Id { get; set; }
	public string Adi { get; set; }
	public string Aciklama { get; set; }

}
