using System;
using TemplateMethodPattern.Entity;

namespace TemplateMethodPattern
{
    static class Program
    {
        static void Main(string[] args)
        {
            IceCreamVendor iceCreamVendor = new IceCreamVendor();
            iceCreamVendor.SellProduct();

            MineralWaterVendor mineralWaterVendor = new MineralWaterVendor();
            mineralWaterVendor.SellProduct();
        }
    }
}
