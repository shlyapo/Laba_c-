using System;
using System.Collections.Generic;
using System.Text;

namespace instrumental
{
    interface IMoved
    {
        public string Place { get; }
        public void MovedIntrumental(string place);
    }
}
