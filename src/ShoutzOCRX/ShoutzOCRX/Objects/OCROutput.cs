using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoutzOCRX.Objects
{
    public struct OCROutput
    {
        /// <summary>
        /// A float from 0-1 determining confidence. 1 being 100% condident.
        /// </summary>
        public float Confidence;
        /// <summary>
        /// The word that the data has been aquired from.
        /// </summary>
        public SingleWord DidReadFrom;
        /// <summary>
        /// Output in string form
        /// </summary>
        public string StringData;
        /// <summary>
        /// Output in int form
        /// </summary>
        public int IntegerData;
        /// <summary>
        /// Did the operation succeed?
        /// </summary>
        internal bool Success;
    }
}
