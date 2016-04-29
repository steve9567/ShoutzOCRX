using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoutzOCRX.Objects
{
    public class pxStream
    {
        public List<px> Data = new List<px>();

        public int Width;
        public int Height;

        public px this[int x, int y]
        {
            get
            {
                return Data[y * Width + x];
            }
        }

        public pxStream(int Width, int Height)
        {
            int x = 0;

            this.Width = Width;
            this.Height = Height;
            
        }
    }
}
