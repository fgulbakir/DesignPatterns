﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactoryApp.AbstractProducts;

namespace AbstractFactoryApp
{
    class Client
    {

        private readonly Shirt _shirt;
        private readonly Trousers _trousers;



        public Client(ClothesFactory factory )
        {
            _shirt = factory.CreateShirt();
            _trousers = factory.CreateTrousers();

        }

        public string ChoosenClothes()
        {

            return $"My prefer is {_shirt.GetType().Name} and {_trousers.GetType().Name} ";
        }


    }
}
