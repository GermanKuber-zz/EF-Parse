using System;
using System.Collections.Generic;
using System.Linq;
using Optional;

namespace ConsoleApp4
{

    public class Driver : DriverData, IDriver
    {


        public Driver(string name, List<Travel> travels)
            : base(name, travels)
        {

        }
        protected Driver()
        {

        }
        private ITravels _travels => new Travels(Travels.ToList<ITravel>());
        IReadOnlyCollection<ITravel> IDriver.Travels => _travels.Get();

        Option<string> IDriver.Name => string.IsNullOrWhiteSpace(this.Name)
                                        ? Option.None<string>()
                                        : Option.Some<string>(this.Name);


        public void UpdateName(string newName)
        {
            if (newName.Length < 10)
                throw new ArgumentException();
            this.Name = newName;
        }
        public void AcceptTravel(ITravel travel)
        {
            if (!IsBusy)
                _travels.Add(travel);
        }

        public void UpdateCurrentTravel(string name) =>
            _travels.GetLast()
                    .UpdateTravel(name);

    }
}
