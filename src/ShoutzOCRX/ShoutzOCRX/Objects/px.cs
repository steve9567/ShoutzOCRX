using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoutzOCRX.Objects
{
    /// <summary>
    /// A single pixle. Can be refernced as a true, false, 0 or 1.
    /// </summary>
    public struct px
    {
        byte _v;

        public bool value
        {
            get
            {
                return (_v == 1);
            }
            set
            {
                if (value == true)
                    _v = 1;
                else
                    _v = 0;
            }
        }

        public static implicit operator px(byte v)
        {
            return new px() { _v = v };
        }

        public static implicit operator int (px p)
        {
            return p._v;
        }

        public static implicit operator px (bool p)
        {
            return new px() { value = p };
        }

        public static implicit operator bool (px p)
        {
            return p.value;
        }
    }
}
