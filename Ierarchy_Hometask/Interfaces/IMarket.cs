using Ierarchy_Hometask.Entities;
namespace Ierarchy_Hometask.Interfaces
{
    internal interface IMarket
    {
        public List<Product> Products { get; }
        public void AddProduct(Product product);
        void RemoveProductByNo(int no);
        void Sell(int no);
    }
}
