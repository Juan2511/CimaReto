using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CimaReto.UI.Data
{
    public class PaginationTable
    {
        public int Page { get; set; } = 1;
        public int QuantityPerPage { get; set; } = 10;
    }
}
