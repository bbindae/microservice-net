namespace ShoppingCart
{
    public class ShoppingCartStore : IShoppingCartStore
    {
        public string Get(int userId)
        {
            return "Hello Cart";
        }
    }
}