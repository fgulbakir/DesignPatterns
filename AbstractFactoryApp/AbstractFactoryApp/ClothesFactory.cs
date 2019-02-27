using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactoryApp.AbstractProducts;

namespace AbstractFactoryApp
{
    abstract class ClothesFactory
    {
        public abstract Shirt CreateShirt();
        public abstract Trousers CreateTrousers();

    }
}
