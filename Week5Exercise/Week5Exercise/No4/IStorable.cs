﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5Exercise.No4
{
    public interface IStorable : IPrintable
    {
        void Read();
        void Write();
    }
}

