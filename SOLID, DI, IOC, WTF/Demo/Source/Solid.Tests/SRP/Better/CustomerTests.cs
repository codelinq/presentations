using System;
using System.Configuration;
using NUnit.Framework;
using Shouldly;
using Solid.Demo.SRP.Better;

namespace Solid.Tests.SRP.Better
{
    [TestFixture]
    public class given_a_known_customer_id
    {
        private Repository<Customer> _customerRepo;

        [SetUp]
        public void Setup()
        {
            var dbContext = new DBContext { ConnectionString = ConfigurationManager.ConnectionStrings["myData"].ConnectionString };
            _customerRepo = new Repository<Customer>(dbContext);
        }

        [Test, Ignore]
        [TestCase("{BD13EFE0-7D57-4E87-A088-8997DCD083C5}", "Bob")]
        public void should_find_the_customer(Guid id, string name)
        {
            var customer = _customerRepo.FetchById(id);
            customer.Name.ShouldMatch(name);
        }
    }
}
