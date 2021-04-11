﻿namespace DoFactoryProtoTypePro.Models
{
    public class ConcretePrototype1 : Prototype
    {
        public ConcretePrototype1(string id)
          : base(id){}

        // Returns a shallow copy
        public override Prototype Clone()
        {
            return (Prototype)this.MemberwiseClone();
        }
    }
}
