using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoutzOCRX.Engine.Internal
{
    internal struct Rect
    {
        internal float TopLeftX;
        internal float TopLeftY;
        internal float BottomRightX;
        internal float BottomRightY;

        internal float DataWhiteRatio;

        internal int Width
        {
            get
            {
                return (int)(BottomRightX - TopLeftX);
            }
        }

        internal int Height
        {
            get
            {
                return (int)(TopLeftY - BottomRightY);
            }
        }
    }
}
