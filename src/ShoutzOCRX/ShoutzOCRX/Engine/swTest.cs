using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoutzOCRX.Engine
{
    public class swTest
    {
        public static int swtesting(Objects.pxStream myStream)
        {
            int iLineValue = 0;
            int iWidth = myStream.Width;
            int iHeight = myStream.Height;

            for (int y = 0; y < iHeight; y++)
                for (int x = 0; x < iWidth; x++)
                {
                    if (myStream[x, y])
                        iLineValue++;
                }
    


            return 0;

        }
    }
}
