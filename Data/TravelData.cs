using System;
using System.Collections.Generic;

namespace ConsoleApp4
{
    public class TravelData
    {
        public int Id { get; protected set; }
        public string Name { get; protected set; }
        public List<Address> Address { get; protected set; } = new List<Address>();

        public TravelData(string name, List<Address> address)
        {
            if (name == null)
                throw new ArgumentNullException(nameof(name));
            if (address == null)
                throw new ArgumentNullException(nameof(address));
            Name = name;
            Address = address;
        }
        protected TravelData()
        {

        }
    }
}