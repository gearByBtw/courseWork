using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pawnshop.Models
{
    internal class Lot
    {
        public int Id { get; set; }

        public string Item { get; set; }

        public string Client_FullName { get; set; }

        public double Price { get; set; }

        public double Price_given { get; set; }

        public DateTime date { get; set; }

        public DateTime date_expire { get; set;}

        public Lot(int id, string item, string client, double price, double price_given, DateTime date, DateTime date_expire)
        {
            Id = id;
            Item = item;
            Client_FullName = client;
            Price = price;
            Price_given = price_given;
            this.date = date;
            this.date_expire = date_expire;
        }
    }
}
