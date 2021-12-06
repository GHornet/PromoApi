using System;

namespace PromoApi.Models
{
    public class Item
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string CreationData { get; set; }
        public string ExpirationData { get; set; }
        public string Expired { get; set; }
        public string Used { get; set; }
        public string MoneyDiscount { get; set; }
        public int MoneyValue { get; set; }
        public string PercentDiscount { get; set; }
        public int PercentValue { get; set; }
        public string ItemDiscount { get; set; }
        public int ItemValue { get; set; }
        public string TimeDiscount { get; set; }
        public int DayTimeDiscountValue { get; set; }
        public int NightTimeDiscountValue { get; set; }
    }
}
