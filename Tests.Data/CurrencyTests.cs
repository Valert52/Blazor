using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Abc.Data;
namespace Abc.Tests.Data;

[TestClass]
public sealed class CurrencyTests
{
    private Currency currency;

    [TestInitialize] public void Initialize() => currency = new Currency();

    [TestMethod] public void CanCreateTest() => Assert.IsNotNull(currency);
}
