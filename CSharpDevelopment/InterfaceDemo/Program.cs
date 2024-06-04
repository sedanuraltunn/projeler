using InterfaceDemo;


var manager = new UserManager(new MemoryCache());
manager.DeleteUser(1);
manager.AddNewUser(new User());
manager.GetUsers();

var manager2 = new UserManager(new RedisCache());
manager2.DeleteUser(1);
manager2.AddNewUser(new User());
manager2.GetUsers();
