namespace InheritanceDemo;

internal class A
{
	public A()
	{
		Console.WriteLine("A ctor çalıştı");
	}
    public A(object obj)
    {
        Console.WriteLine("A1 ctor çalıştı");
    }
}

internal class B:A
{
	public B()
	{
        Console.WriteLine("B ctor çalıştı");
    }
    public B(object obj)
    {
        Console.WriteLine("B1 ctor çalıştı");
    }
}

internal class C:B
{
	public C()
	{
        Console.WriteLine("C ctor çalıştı");
    }
    public C(object obj):base(obj)
    {
        Console.WriteLine("C1 ctor çalıştı");
    }
}
