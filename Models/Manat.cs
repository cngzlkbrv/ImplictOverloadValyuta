using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    internal class Manat
    {
        public double Money { get; set; }
        public Manat(double money)
        {
            Money = money;
        }
        public static implicit operator Manat(Dollar money)
        {
            return new Manat(money.Money*1.7);
        }
        public static implicit operator Manat(Euro money)
        {
            return new Manat(money.Money * 2);
        }
    }
}
