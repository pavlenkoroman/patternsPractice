using Iterator.Iterator;

namespace Iterator
{
    public interface IMenu
    {
        public IIterator<MenuItem> CreateIterator();
    }
}