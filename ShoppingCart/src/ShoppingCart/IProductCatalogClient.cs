
using System.Threading.Tasks;

namespace ShoppingCart
{
    public interface IProductCatalogClient
    {
        Task<string[]> GetShoppingCartItemsAsync(int[] shoppingCartIds);
    }    
}