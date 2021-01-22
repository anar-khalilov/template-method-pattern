using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethodPattern.Entity
{
    class IceCreamVendor : VendorBase
    {
        protected override void PrepareAndServeProduct()
        {
            Console.WriteLine("Preparing and serving ice cream..");
        }
    }
}
