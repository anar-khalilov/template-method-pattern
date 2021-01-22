using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethodPattern.Entity
{
    class MineralWaterVendor : VendorBase
    {
        protected override void PrepareAndServeProduct()
        {
            Console.WriteLine("Prepaing and serving mineral water..");
        }
    }
}
