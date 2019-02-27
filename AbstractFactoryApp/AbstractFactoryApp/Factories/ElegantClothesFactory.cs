using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactoryApp.AbstractProducts;
using AbstractFactoryApp.Products;

namespace AbstractFactoryApp.Factories
{
    class ElegantClothesFactory : ClothesFactory
    {
        public override Shirt CreateShirt()
        {
            return new DressShirt();
        }

        public override Trousers CreateTrousers()
        {
            return new SuitTrousers();
        }
    }
}
