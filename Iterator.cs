﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorAndCompositeExercise
{
    internal interface Iterator
    {
        bool hasNext();
        Object next();
    }
}
