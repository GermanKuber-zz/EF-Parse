using System;

namespace ConsoleApp4
{
    public class Address : AddressData , IAddress
    {
        public Address(string name) : base(name)
        {
        }

        public void Update(string name)
        {
            this.Name = name;
        }
    }
}
