using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Abc.Data;
    public class CountryCurrency
    {
        public int Id { get; set; }
    public int CountryId { get; set; }
        public int CurrencyId { get; set; }
    public Currency Currency { get; set; }
    }
