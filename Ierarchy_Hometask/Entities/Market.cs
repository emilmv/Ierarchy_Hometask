using Ierarchy_Hometask.Constants;
using Ierarchy_Hometask.Exceptions;
using Ierarchy_Hometask.Interfaces;
namespace Ierarchy_Hometask.Entities
{
    internal class Market : IMarket
    {
        public List<Product> Products { get; set; }
        public double AlcoholPercentLimit { get; set; }
        public int AlcoholProductLimit { get; set; }
        public int TotalAmount { get; set; }
        private double totalProfit = 0;

        void GetDrinks()
        {
            List<Product> products = new List<Product>();
        }
        void GetAlcoholProducts()
        {

        }
        void GetExpiredProducts()
        {

        }
        void RemoveExpiredProducts()
        {

        }

        public void AddProduct(Product product)
        {
            Products.Add(product);
        }

        public void RemoveProductByNo(int no)
        {
            var product = Products.Find(p => p.No == no);
            if (product != null)
                Products.Remove(product);
            else throw new NotFoundException(ConsoleMessages.ItemNotFound);
        }

        public void Sell(int no)
        {
            var product = Products.Find(p => p.No == no);
            if (product != null)
            {
                totalProfit += product.SalePrice - product.CostPrice;
                Products.Remove(product);
            }
            else throw new NotFoundException(ConsoleMessages.ItemNotFound);
        }
    }
}
