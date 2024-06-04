using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo;

internal partial class UserManager
{
    private readonly ICacheService _cacheService;
    public UserManager(ICacheService cacheService)
    {
        _cacheService = cacheService;
    }
    public void DeleteUser(int id) 
    {
        //dbden kullanıcı silindi
        _cacheService.Remove(CacheKeys.USER_CACHE_KEY);
    }
    public void AddNewUser(User user)
    {
        //dbyekullanıcı eklendi
        _cacheService.Remove(CacheKeys.USER_CACHE_KEY);
    }
    public List<User> GetUsers()
    {
        //kullanıcılar dbden getirildi
        if (_cacheService.IsExist(CacheKeys.USER_CACHE_KEY))
            return (List<User>)_cacheService.Get(CacheKeys.USER_CACHE_KEY);
         
        var dataFromDb = new List<User>()
        {
            new User() {Id=1,Name="Seda Nur ALTUN"},
            new User() {Id=2,Name="Serhat ALTUN"}
        };
        _cacheService.Add(CacheKeys.USER_CACHE_KEY, dataFromDb);
        return dataFromDb;
    }
}
