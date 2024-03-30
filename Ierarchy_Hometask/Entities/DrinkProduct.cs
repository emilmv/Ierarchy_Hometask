namespace Ierarchy_Hometask.Entities
{
    internal class DrinkProduct : Product
    {
        public byte AlcoholPercent { get; set; }

        public DrinkProduct(int no, string name, double costPrice, double salePrice, DateTime expireDate, byte alcoholPercent) : base(no, name, costPrice, salePrice, expireDate)
        {
            AlcoholPercent = alcoholPercent;
            No= no;
            Name = name;
            CostPrice = costPrice;
            SalePrice = salePrice;
            ExpireDate = expireDate;
        }
    }
}
