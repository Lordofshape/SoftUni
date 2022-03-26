using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stocks 
{
    public class Investor
    {
        private List<Stock> portfolio;
        public Investor(string fullName, string emailAddress, decimal moneyToInvest, string brokerName)
        {
            FullName = fullName;
            EmailAddress = emailAddress;
            MoneyToInvest = moneyToInvest;
            BrokerName = brokerName;
            portfolio = new List<Stock>();
        }

        public string FullName { get; set; }
        public string EmailAddress { get; set; }
        public decimal MoneyToInvest { get; set; }
        public string BrokerName { get; set; }
        public int Count { get { return portfolio.Count; } }
        public void BuyStock(Stock stock)
        {
            if (stock.MarketCapalization>10000 && stock.PricePerShare<=MoneyToInvest)
            {
                MoneyToInvest -= stock.PricePerShare;
                portfolio.Add(stock);
            }
        }
        public string SellStock(string companyName, decimal sellPrice)
        {
            Stock stock = FindStock(companyName);
            if (stock==null)
            {
                return $"{companyName} does not exist.";
            }
            if (stock.PricePerShare<=sellPrice)
            {
                return $"Cannot sell { companyName}.";
            }
            MoneyToInvest += sellPrice;
            portfolio.Remove(stock);
            return $"{ companyName} was sold.";
        }
        public Stock FindStock(string companyName)
        {
            return portfolio.FirstOrDefault(x => x.CompanyName == companyName);

        }
       public Stock FindBiggestCompany()
        {
            return portfolio.OrderBy(x => x.MarketCapalization).LastOrDefault();
        }
       public string InvestorInformation()
        { 
            return $"The investor {FullName} with a broker {BrokerName} has stocks: {portfolio}";
            
        }

    }
}
