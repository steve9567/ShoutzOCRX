using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShoutzOCRX;

namespace ServiceTests
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShoutzOCRX.Objects.SingleWord word = new ShoutzOCRX.Objects.SingleWord();
            ShoutzOCRX.Objects.pxStream stream = word.ImageToPXStream(pictureBox1.Image);
            word.SetDataStream(stream);
            word.OCRReadFromData();

            int g = 0;
            foreach(byte b in stream.Data)
            {
                richTextBox1.Text += b.ToString();
                if (g % stream.Width == 0)
                    richTextBox1.Text += "\n";
                g++;
            }
            
        }
    }
}
