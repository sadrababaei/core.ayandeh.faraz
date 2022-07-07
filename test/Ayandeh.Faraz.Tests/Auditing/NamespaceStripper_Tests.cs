using Ayandeh.Faraz.Auditing;
using Ayandeh.Faraz.Test.Base;
using Shouldly;
using Xunit;

namespace Ayandeh.Faraz.Tests.Auditing
{
    // ReSharper disable once InconsistentNaming
    public class NamespaceStripper_Tests: AppTestBase
    {
        private readonly INamespaceStripper _namespaceStripper;

        public NamespaceStripper_Tests()
        {
            _namespaceStripper = Resolve<INamespaceStripper>();
        }

        [Fact]
        public void Should_Stripe_Namespace()
        {
            var controllerName = _namespaceStripper.StripNameSpace("Ayandeh.Faraz.Web.Controllers.HomeController");
            controllerName.ShouldBe("HomeController");
        }

        [Theory]
        [InlineData("Ayandeh.Faraz.Auditing.GenericEntityService`1[[Ayandeh.Faraz.Storage.BinaryObject, Ayandeh.Faraz.Core, Version=1.10.1.0, Culture=neutral, PublicKeyToken=null]]", "GenericEntityService<BinaryObject>")]
        [InlineData("CompanyName.ProductName.Services.Base.EntityService`6[[CompanyName.ProductName.Entity.Book, CompanyName.ProductName.Core, Version=1.10.1.0, Culture=neutral, PublicKeyToken=null],[CompanyName.ProductName.Services.Dto.Book.CreateInput, N...", "EntityService<Book, CreateInput>")]
        [InlineData("Ayandeh.Faraz.Auditing.XEntityService`1[Ayandeh.Faraz.Auditing.AService`5[[Ayandeh.Faraz.Storage.BinaryObject, Ayandeh.Faraz.Core, Version=1.10.1.0, Culture=neutral, PublicKeyToken=null],[Ayandeh.Faraz.Storage.TestObject, Ayandeh.Faraz.Core, Version=1.10.1.0, Culture=neutral, PublicKeyToken=null],]]", "XEntityService<AService<BinaryObject, TestObject>>")]
        public void Should_Stripe_Generic_Namespace(string serviceName, string result)
        {
            var genericServiceName = _namespaceStripper.StripNameSpace(serviceName);
            genericServiceName.ShouldBe(result);
        }
    }
}
