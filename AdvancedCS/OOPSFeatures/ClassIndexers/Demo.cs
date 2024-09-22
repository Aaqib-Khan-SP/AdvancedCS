using Core.Interfaces;
using Core.Models.List;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCS.OOPSFeatures.ClassIndexers
{
    internal class Demo : IRunnable
    {
        public void Run()
        {
            Cart cart = new Cart();
            for(int i=0; i < cart.Length; i++)
            {
                Console.WriteLine(cart[i]);
            }
        }
    }
}
