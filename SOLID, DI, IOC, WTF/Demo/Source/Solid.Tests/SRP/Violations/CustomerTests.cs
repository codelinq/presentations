using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

using Shouldly;

using Solid.Demo.SRP.Violations;

namespace Solid.Tests.SRP.Violations
{
    [TestFixture]
    public class given_a_valid_customer_id
    {
        [Test]
        [TestCase("{BD13EFE0-7D57-4E87-A088-8997DCD083C5}", "Bob")]
        public void should_find_the_customer(Guid id, string name)
        {
            var customer = new Customer(id);

            customer.Name.ShouldMatch(name);
        }
    }
}
