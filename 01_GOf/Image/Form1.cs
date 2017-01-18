using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Images
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            try
            {
                var image = Image.FromFile(@"C:\Users\Public\Pictures\Sample Pictures\Koala.jpg");

                //var array = ImageToByte2(image);

                var x = GetEntryXmlDoc(ImageToByte2(image));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public static XmlDocument GetEntryXmlDoc(byte[] Bytes)
        {
            var xmlDoc = new XmlDocument();

            using (var ms = new MemoryStream(Bytes))
            {
                xmlDoc.Load(ms);
            }

            return xmlDoc;
        }

        public static byte[] ImageToByte2(Image img)
        {
            var byteArray = new byte[0];

            using (var stream = new MemoryStream())
            {
                img.Save(stream, System.Drawing.Imaging.ImageFormat.Png);

                stream.Close();

                byteArray = stream.ToArray();
            }

            return byteArray;
        }

    }
}
