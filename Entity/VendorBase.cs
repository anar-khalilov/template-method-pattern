using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethodPattern.Entity
{
    abstract class VendorBase
    {
        // Our template method with pre-defined structure - a skeleton.
        public void SellProduct()
        {
            SayHello();                 // Standard step #1
            PrepareAndServeProduct();   // Customizable step #2
            TakeMoneyAndSayThanks();    // Standard step #3
        }

        protected void SayHello() => Console.WriteLine("Hello!");
        protected abstract void PrepareAndServeProduct();
        protected void TakeMoneyAndSayThanks() => Console.WriteLine("Thanks!");
    }
}
