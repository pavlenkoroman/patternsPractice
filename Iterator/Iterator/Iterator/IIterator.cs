using System;

namespace Iterator.Iterator
{
    public interface IIterator
    {
        bool HasNext();

        Object Next();
    }
}