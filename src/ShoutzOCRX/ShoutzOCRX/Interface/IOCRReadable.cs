using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoutzOCRX.Interface
{
    internal interface IOCRReadable
    {
        Objects.pxStream DataStream { get; set; }
        bool SetDataStream(Objects.pxStream stream);
        Objects.OCROutput GetOutput();
        Task OCRReadFromData();
    }
}
