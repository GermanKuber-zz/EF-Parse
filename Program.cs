using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
namespace ConsoleApp4
{
    class Program
    {
        private static IMapper _mapper;
        private static EFCoreDemoContext _context;

        static async Task Main(string[] args)
        {
            //ConfigureMappers();
            _context = new EFCoreDemoContext();
            //AddNewDriver();

            var drivers = await GetDriversAsync();

            var driver0 = drivers[0];
            var driver1 = drivers[1];


            driver0.Name.Match(
                x => Console.WriteLine(x),
                () => Console.WriteLine("Nada"));
            driver1.Name.Match(
                        x => Console.WriteLine(x),
                        () => Console.WriteLine("Nada"));
                 

            Console.WriteLine("Hello World!");
        }
        private static async Task<List<IDriver>> GetDriversAsync()
        {
            var drivers = await _context.Drivers.Include(x => x.Travels)
                                                       .ThenInclude(s => s.Address)
                                                       .ToListAsync();
            return drivers.ToList<IDriver>();
        }
        private static void AddNewDriver()
        {
            var driverss = new Driver(string.Empty, new List<Travel> { new Travel("Primer travel", new List<Address> { new Address("Primera direccion"), new Address("Segunda direccion") }) });
            _context.Drivers.Add(driverss);
            _context.SaveChanges();
        } 
    }
}
