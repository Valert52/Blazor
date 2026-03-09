using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Abc.Data;

namespace Abc.Tests.Data;

[TestClass]
public sealed class CountryTests
{
    private Country country;

    [TestInitialize] public void Initialize() => country = new Country();

    [TestMethod] public void CanCreateTest() => Assert.IsNotNull(country);
}
