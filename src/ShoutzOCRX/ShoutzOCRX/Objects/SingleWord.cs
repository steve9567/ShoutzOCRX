using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShoutzOCRX.Interface;

namespace ShoutzOCRX.Objects
{
    /// <summary>
    /// Class containing input and output data for OCR operations.
    /// </summary>
    public class SingleWord : Interface.IOCRReadable
    {
        private pxStream _pxs;
        private OCROutput _output;

        /// <summary>
        /// Primary data stream.
        /// </summary>
        public pxStream DataStream
        {
            get
            {
                return _pxs;
            }

            set
            {
                _pxs = value;
            }
        }

        /// <summary>
        /// Gets the output in OCROutput format.
        /// </summary>
        /// <returns>OCROutput if OCROutput has a success flag, InvalidOperationException if not.</returns>
        public OCROutput GetOutput()
        {
            if (_output.Success)
                return _output;
            else
                throw new InvalidOperationException("Output not successful.");
        }

        /// <summary>
        /// Async OCRRead call from pxStream 'SingleWord.DataStream'
        /// </summary>
        /// <returns>Void. Sets OCROutput success flag to true and populates its data.</returns>
        public void OCRReadFromData()
        {
            Engine.swTest.swtesting(_pxs);
            //Implement OCR Engine
        }

        /// <summary>
        /// Sets the data stream to be used.
        /// </summary>
        /// <param name="stream">Datastream to set</param>
        /// <returns>True if success, false if not.</returns>
        public bool SetDataStream(pxStream stream)
        {
            _pxs = stream;
            return true;
        }

        /// <summary>
        /// Converts an img to a pxStream for processing. Does not binarize.
        /// </summary>
        /// <param name="img">Binarized image to use</param>
        /// <returns>pxStream containing data from img.</returns>
        public pxStream ImageToPXStream(Image img)
        {
            int width = img.Width;

            pxStream stream = new pxStream(width, img.Height);

            Bitmap map = new Bitmap(img);

            for(int x = 0; x < img.Width; x++)
            {
                for(int y = 0; y < img.Height; y++)
                {
                    if(map.GetPixel(x, y).R < 10)
                    {
                        stream.Data.Add(1);
                    }
                    else
                    {
                        stream.Data.Add(0);
                    }
                }
            }

            return stream;
        }
    }
}
