namespace Ierarchy_Hometask.Entities
{
    internal class Product
    {
        public int No { get; set; }
        public string? Name { get; set; }
        public double CostPrice { get; set; }
        public double SalePrice { get; set; }
        public DateTime ExpireDate { get; set; }

        public Product(int no, string? name, double costPrice, double salePrice, DateTime expireDate)
        {
            No = no;
            Name = name;
            CostPrice = costPrice;
            SalePrice = salePrice;
            ExpireDate = expireDate;
        }
    }
}
