using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace ShoppingCart
{
    public class ProductCatalogClient : IProductCatalogClient
    {
        private static string productcatlogBaseUrl = "https://private-90fc17-productcatalogmicroservice2.apiary-mock.com";
        private static string _getProductPathTemplate ="/products?productIds=[{0}]";

        public async Task<string[]> GetShoppingCartItemsAsync(int[] shoppingCartIds)
        {
            throw new NotImplementedException();
        }

        private static async Task<HttpResponseMessage> RequestProductFromProductCatalogue(int[] productCatalogueIds)
        {
            var productResource = string.Format(_getProductPathTemplate, string.Join(",", productCatalogueIds));
            using(var httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(productcatlogBaseUrl);
                return await httpClient.GetAsync(productResource).ConfigureAwait(false);
            }
        }

        private static async Task<IEnumerable<ShoppingCartItem>> ConvertToShoppingCartItems(HttpResponseMessage response)
        {
            
        }

        private class ProductCatalogProduct
        {
            public string ProductId {get;set;}
            public string ProductName {get; set;}
            public string ProductDescription {get; set;}
            public decimal Price {get; set;}
        }
    }
}