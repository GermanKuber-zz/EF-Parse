using System;
using System.Collections.Generic;
namespace ConsoleApp4
{

    public class DriverData
    {
        public int Id { get; protected set; }
        public bool IsBusy { get; protected set; }
        public string Name { get; protected set; }
        public List<Travel> Travels { get; protected set; }

        protected DriverData(string name, List<Travel> travels)
        {
            if (name == null)
                throw new ArgumentNullException(nameof(name));
            if (travels == null)
                throw new ArgumentNullException(nameof(travels));
            Name = name;
            Travels = travels;
        }

        protected DriverData()
        {

        }
    }
}
