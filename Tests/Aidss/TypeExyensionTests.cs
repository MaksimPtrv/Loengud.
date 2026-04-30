using Abc.Aids;
using Abc.Tests.Aids;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Abc.Tests.Aids;

[TestClass] public class TypeExtensionTests : TestAids
{
    [TestInitialize] public void Initialize() => type = typeof(TypeExtension);
    [TestMethod] public void IsBoolTest() { Assert.Inconclusive(); }
}
