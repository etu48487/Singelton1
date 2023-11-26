using System;

namespace Iterator
{
    public interface IteratorInterface
    {
        bool HasNext();
        object Next();
    }
}