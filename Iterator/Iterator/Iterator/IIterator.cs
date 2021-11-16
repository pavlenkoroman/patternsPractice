using System;

namespace Iterator.Iterator
{
    public interface IIterator
    {
        bool HasNext();

        MenuItem Next();
    }
}