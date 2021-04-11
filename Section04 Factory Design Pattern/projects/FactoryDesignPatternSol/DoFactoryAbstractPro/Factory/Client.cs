using DoFactoryAbstractPro.Interfaces;
using DoFactoryAbstractPro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoFactoryAbstractPro.Factory
{
    public class Client
    {
        private IBuilder _abstractProductA;
        private IBuilder _abstractProductB;

        // Constructor

        public Client(IAbstractFactory factory)
        {
            _abstractProductB = factory.CreateProduct();
            _abstractProductA = factory.CreateProduct();
        }

        public void Run()
        {
            _abstractProductB.Interact(_abstractProductA);
        }
    }
}
