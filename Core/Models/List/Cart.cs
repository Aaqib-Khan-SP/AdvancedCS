using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models.List
{
    public class Cart
    {
        public decimal[] ItemPrices = new decimal[] {
            34.2m,53.5m,12.5m,67.8m,5.78m
        };

        public int Length => ItemPrices.Length;

        public decimal this[int index]
        {
            get => ItemPrices[index];
        }
    }
}