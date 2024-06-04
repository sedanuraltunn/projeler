using FirstDemo;

using (var context=new MsbStoreContext())
{
    context.Database.EnsureCreated();
     
}