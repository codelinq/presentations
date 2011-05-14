
namespace Solid.Demo.SRP.Better
{
    public abstract class SqlVisitor<T>
    {
        internal abstract void Visit(T item);

        public abstract string Query { get; }
    }
}
