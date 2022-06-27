namespace Favour.Persistance
{
    public class Init
    {
        public static void Initialize(FavourContext context)
        {
            context.Database.EnsureCreated();
        }
    }
}
