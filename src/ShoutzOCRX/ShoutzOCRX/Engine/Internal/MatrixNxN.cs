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
        private List<Rect> Cols = new List<Rect>();
        private List<Rect> Rows = new List<Rect>();

        private pxStream data;

        /// <summary>
        /// A system for splitting an image into rows and columns.
        /// </summary>
        /// <param name="dataStream">The image in pxStream form</param>
        /// <param name="MatrixWidth">The amount of columns</param>
        /// <param name="MatrixHeight">The amount of rows</param>
        internal MatrixNxN(pxStream dataStream, int MatrixWidth, int MatrixHeight)
        {
            data = dataStream;

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

        /// <summary>
        /// Converts a generic matrix col or row to a pxStream of the same size
        /// </summary>
        /// <param name="IsCol">Is the selected indexer for a col or a row?</param>
        /// <param name="index">the row or col number to process</param>
        /// <returns>a pxStream containing an image the same size as the col or row</returns>
        internal pxStream MatrixGroupToStream(bool IsCol, int index)
        {
            pxStream stream = new pxStream(IsCol ? Cols[index].Width : Rows[index].Width, IsCol ? Cols[index].Height : Rows[index].Height);
            
            if(IsCol)
            {
                for(int y = 0; y < Cols[index].Height; y++)
                {
                    for(int x = 0; x < Cols[index].Width; x++)
                    {
                        stream[x, y] = data[x, y];
                    }
                }
            }
            else
            {
                for (int y = 0; y < Rows[index].Height; y++)
                {
                    for (int x = 0; x < Rows[index].Width; x++)
                    {
                        stream[x, y] = data[x, y];
                    }
                }
            }

            return stream;
        }
    }
}
