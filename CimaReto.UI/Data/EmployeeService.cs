using System;
using System.Linq;
using System.Threading.Tasks;

namespace CimaReto.UI.Data
{
    public class EmployeeService
    {
        private static readonly string[] Names = new[]
        {
            "Jose","Maria","Juan","Miguel","Antonio","Cesar","Manuel","Rosa","Mercedes","Talia","Pedro","Paola"
        };

        private static readonly string[] LastNames = new[]
        {
            "Arias","Perez","Torres","Prado","Martinez","Luna","Benavides","Rivera","Ortiz","Blas","Muñoz","Rios"
        };

        private static readonly string[] Directions = new[]
        {
            "Torres 12","Grau 45","Tacna 4540","Brisas 454","Bolognesi 45","Violetas 44","Lunares 454","Ugarte 887","Nuñez 458","Zela 4545","Pineda 1484","Corregidores 852"
        };

        public Task<Employee[]> GetForecastAsync(DateTime startDate)
        {
            int num = 0;
            var rng = new Random();
            return Task.FromResult(Enumerable.Range(1, 24).Select(index => new Employee
            {
                CheckA = false,
                Id = (num = num + 1),
                Direction = Directions[rng.Next(Directions.Length)],
                LastName = LastNames[rng.Next(LastNames.Length)],
                Name = Names[rng.Next(Names.Length)]
            }).ToArray());;
        }
    }
}
