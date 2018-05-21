using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public delegate void Draw();
    public delegate void Draw<T1, T2>(T1 x, T2 y);
}
