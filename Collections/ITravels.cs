using System.Collections.Generic;

namespace ConsoleApp4
{
    public interface ITravels
    {
        void Add(ITravel travel);
        void Delete(ITravel travel);
        IReadOnlyCollection<ITravel> Get();
        ITravel GetLast();
    }

}
