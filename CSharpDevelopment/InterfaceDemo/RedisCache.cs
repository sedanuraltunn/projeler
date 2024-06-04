namespace InterfaceDemo;

internal class RedisCache : ICacheService
{
    public void Add(string key, object data)
    {
        Console.WriteLine("redis ile eklendi");
    }

    public object Get(string key)
    {
        Console.WriteLine("redis ile getirildi");
        return null;
    }

    public bool IsExist(string key)
    {
        return false;
    }

    public void Remove(string key)
    {
        Console.WriteLine("redis ile silindi");
    }
}
