using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accessors
{
    class TvSet
    {
        private int _volume;
        public int Volume
        {
            get
            {
                return _volume;
            }
            set
            {
                if (value < 0)
                {
                    _volume = 0;
                }
                else if (value > 201)
                {
                    _volume = 200;
                }
                else
                {
                    _volume = value;
                }
            }
        }
    }
}
