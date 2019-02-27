using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactoryApp.AbstractProducts;
using AbstractFactoryApp.Products;

namespace AbstractFactoryApp.Factories
{
    class CasualClothesFactory : ClothesFactory
    {
        public override Shirt CreateShirt()
        {
            return  new PoloShirt();
        }

        public override Trousers CreateTrousers()
        {
            return new Jeans();
        }
    }
}
