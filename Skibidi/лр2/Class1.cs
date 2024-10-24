using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лр2_класс
{
    internal class Tovar
    {
        public string name;
        public double price;

        public Tovar(string name_, double price_)
        {
            name = name_;
            price = price_;

        }

        public class history
        {
            public int amount;
            public history(int amount_)
            {
                amount = amount_;
            }
        }
        public enum groups
        {
            pistol,
            shotgun,
            rifle
        }

    }
}
