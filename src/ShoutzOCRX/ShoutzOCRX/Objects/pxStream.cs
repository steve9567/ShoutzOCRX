﻿using System;
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

        public px this[int x, int y]
        {
            get
            {
                return Data[y * Width + x];
            }
        }

        public pxStream(int Width)
        {
            this.Width = Width;
        }
    }
}
