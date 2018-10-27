using System;
using System.Collections.Generic;
using System.Text;

namespace FigureLibrary
{
    public abstract class Figure
    {
        public virtual double GetArea()
        {
            return 0;
        }
    }
}
