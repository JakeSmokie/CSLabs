﻿using System;
using ClassLib;

namespace CSLabs
{
    public interface IPathReader
    {
        string Read(ICalcIO inOutStream, Predicate<string> pathCorrectnessPredicate = null);
    }
}