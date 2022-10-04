using System;

namespace task8
{
    class Invoice
    {
        public string Article { get; set; }
        public int Quantity { get; set; }
        private int account;
        private string customer;
        private string provider;
        private int price;

        public Invoice(int account, string customer, string provider, int price)
        {
            this.account = account;
            this.customer = customer;
            this.provider = provider;
            this.price = price;
            Article = "";
            Quantity = 0;
        }
        private double PriceWithPDV()
        {
            return price * Quantity * 1.2;
        }
        private double PriceWithoutPDV()
        {
            return (double)price * Quantity;
        }

        public override string ToString()
        {
            return "Отчет №" + account + "\nКлиент: " + customer + "\nПоставщик: " + provider + "\nПоставляемый продукт:\nНазвание - " + Article
                + ", Количество - " + Quantity + ", Цена поштучно - " + price + "\nСтоимость без ПДВ: " + PriceWithoutPDV().ToString() + ", с ПДВ: " + PriceWithPDV().ToString();
        }
    }
}