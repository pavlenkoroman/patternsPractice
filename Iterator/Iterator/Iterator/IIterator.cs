using System;

namespace Iterator.Iterator
{
    public interface IIterator<T> where T : IMenuItem
    {
        bool HasNext();

        T Next();
    }
}