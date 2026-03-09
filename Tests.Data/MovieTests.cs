using Abc.Data;
using System.Runtime.CompilerServices;

namespace Abc.Tests.Data
{
    [TestClass] public sealed class MovieTests 
    {
       
        private Movie movie;

        [TestInitialize]
        public void Initialize() => movie = new Movie();
        [TestMethod] public void CanCreateTest() => Assert.IsNotNull(movie);
    }
}