using Ierarchy_Hometask.Entities;
namespace Ierarchy_Hometask.Interfaces
{
    internal interface IMarket
    {
        public List<Product> Products { get; }
        void AddProduct();
        void RemoveProductByNo();
        void Sell();
    }
}
