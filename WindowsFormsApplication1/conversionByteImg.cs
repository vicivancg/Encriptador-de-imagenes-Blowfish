using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Collections;

namespace blowfish
{
    class conversionByteImg
    {
        public static byte[] ImageToByteArray (Image imagen)
        {
            MemoryStream streamDatos = new MemoryStream();
            imagen.Save(streamDatos, ImageFormat.Jpeg);
            return streamDatos.ToArray();
        }

        public static Image ByteArrayToImage(byte[] arregloBytes)
        {
            MemoryStream streamDatos = new MemoryStream(arregloBytes);
            Image imagenResultado = Image.FromStream(streamDatos);
            return imagenResultado;
        }

        public static BitArray ByteArrayToBit(byte[] arregloBytes)
        {
            BitArray arregloBits = new BitArray(arregloBytes);
            return arregloBits;
        }

        //public static bita


    }
}
