﻿using System;

namespace Generics
{
    public class GenericList<T>
    {
        public void Add(T value)
        {

        }

        public T this[string index]
        {
            get { throw new NotImplementedException(); }
        }
    }
}
