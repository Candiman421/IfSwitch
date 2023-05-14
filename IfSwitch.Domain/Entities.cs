namespace IfSwitch.Domain
{
    public class Goods
    {
        public int GoodsId { get; set; }
        public string Name { get; set; }
        public string? Brand { get; set; }
        public string? Size { get; set; }
        public string? Volume { get; set; }
        public string? VolumeByDescription { get; set; }
        public int? QuantityPerUnit { get; set; }
        //Characteristics Table'
    }

    public class Company
    {
        public int CompanyId { get; set; }
        public string Name { get; set; }
        public string? Website { get; set; }
    }


    public class Price
    {
        public int PriceId { get; set; }
        public decimal SalesPrice { get; set; }
        public int Quantity { get; set; }
        public decimal PurchasePrice { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal Tax { get; set; }
    }
    public class CompanyGoods
    {
        public int CompanyGoodsId { get; set; }
        public int CompanyId { get; set; }
        public int GoodsId { get; set; }
        public List<Price> Prices { get; set; }
    }

    public class Tax
    {
        public int TaxId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public double TaxRate { get; set; }
        public decimal? TaxSaleAmount { get; set; }
        public string State { get; set; }
        public TaxType TaxType { get; set; }
    }

    public enum TaxType
    {
        FederalCigaretteTax = 1,
        StateSalesTax = 2,
        SalesTax = 3
    }
}