using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Solid.Demo.SRP.Better
{
    class SqlSelectVisitor<T> : SqlVisitor<T>
    {
        private Guid _id;
        private string _query;

        public SqlSelectVisitor(Guid id)
        {
            _id = id;
            _query = "select * from blah where blah = blah";
        }

        internal override void Visit(T item)
        {
            // does nothing;
        }

        public override string Query
        {
            get { return _query; }
        }
    }
}
