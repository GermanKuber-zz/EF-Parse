using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace ConsoleApp4
{
    public class Travels : ITravels
    {
        private readonly List<ITravel> _travels = new List<ITravel>();
        public Travels(List<ITravel> travels)
        {
            _travels = travels;
        }
        public void Add(ITravel travel) => _travels.Add(travel);
        public void Delete(ITravel travel) => _travels.Remove(travel);
        public IReadOnlyCollection<ITravel> Get() => new ReadOnlyCollection<ITravel>(_travels);
        public ITravel GetLast() => _travels.Last();
    }
}
