using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShoutzOCRX.Objects;

namespace ShoutzOCRX.Engine.Internal
{
    internal class MatrixNxN : Matrix
    {
        internal List<Rect> Cols = new List<Rect>();
        internal List<Rect> Rows = new List<Rect>();

        internal MatrixNxN(pxStream dataStream, int MatrixWidth, int MatrixHeight)
        {
            int widthReduced = dataStream.Width / MatrixWidth;
            int heightReduced = dataStream.Height / MatrixHeight;

            for (int c = 0; c < MatrixWidth; c++)
            {
                Cols.Add(new Rect()
                {
                    TopLeftX = widthReduced * c,
                    TopLeftY = 0,
                    BottomRightX = (widthReduced * c) + (widthReduced - 1),
                    BottomRightY = dataStream.Height
                });
            }
            for (int r = 0; r < MatrixHeight; r++)
            {
                Rows.Add(new Rect()
                {
                    TopLeftX = 0,
                    TopLeftY = heightReduced * r,
                    BottomRightX = dataStream.Height,
                    BottomRightY = (heightReduced * r) + (heightReduced - 1)
                });
            }
        }

        internal pxStream MatrixGroupToStream()
    }
}
