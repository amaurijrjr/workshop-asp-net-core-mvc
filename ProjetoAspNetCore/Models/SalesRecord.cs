using System;
using ProjetoAspNetCore.Models.Enums;

namespace ProjetoAspNetCore.Models
{
    public class SalesRecord
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public double Amount { get; set; }
        public SaleStatus StatusProperty { get; set; }
        public Seller Seller { get; set; }

        public SalesRecord()
        {
        }

        public SalesRecord(int id, DateTime date, double amount, SaleStatus statusProperty, Seller seller)
        {
            Id = id;
            Date = date;
            Amount = amount;
            StatusProperty = statusProperty;
            Seller = seller;
        }
    }
}
