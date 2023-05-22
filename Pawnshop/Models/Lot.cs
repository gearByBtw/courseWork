using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Pawnshop.Models
{
    internal class Lot
    {
        public int id { get; set; }

        public string item { get; set; }

        public string client { get; set; }

        public double price { get; set; }

        public double price_given { get; set; }

        public DateTime date { get; set; }

        public DateTime date_expire { get; set;}

        [JsonConstructor]
        public Lot(int id, string item, string client, double price, double price_given, DateTime date, DateTime date_expire)
        {
            this.id = id;
            this.item = item;
            this.client = client;
            this.price = price;
            this.price_given = price_given;
            this.date = date;
            this.date_expire = date_expire;
        }
        
        public Lot() { }

        public override string ToString()
        {
            return $"{id}   {item}   {client}   {price}   {price_given}   {date}   {date_expire}";
        }
    }
}
