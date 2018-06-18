using System;

namespace ConsoleApp4
{
    public class AddressData
    {
        public int Id { get; protected set; }
        public string Name { get; protected set; }

        public AddressData(string name)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
        }
    }
}
