using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Solid.Demo.SRP.Better
{
    class SqlInsertVisitor<T> : SqlVisitor<T>
    {
        private string _query;

        internal override void Visit(T item)
        {
            //loop over properties of item and update Query;
            _query = "insert into blah where blah = blah";
        }

        public override string Query { get { return _query; } }
    }
}
