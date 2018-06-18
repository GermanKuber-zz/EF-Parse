using System.Collections.Generic;

namespace ConsoleApp4
{
    public class Travel : TravelData, ITravel
    {
        public Travel( string name, List<Address> address) : base( name, address)
        {
        }
        public Travel()
        {

        }
        public void AddNewAddress(string name)
        {
            this.Address.Add(new Address(name));
        }

        public void UpdateTravel(string name)
        {
            this.Name = name;
        }
    }
}