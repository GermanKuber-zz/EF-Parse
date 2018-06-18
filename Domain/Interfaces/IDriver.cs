using System.Collections.Generic;
using Optional;

namespace ConsoleApp4
{
    public interface IDriver
    {
        Option<string> Name { get; }
        IReadOnlyCollection<ITravel> Travels { get; }
        void UpdateName(string newName);
        void UpdateCurrentTravel(string name);
    }
}