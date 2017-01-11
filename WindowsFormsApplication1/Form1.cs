using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.IO;

namespace blowfish
{
    public partial class Form1 : Form
    {
        bool tipo = false;
        Image imagenAct = null;
        string rutaImagen = string.Empty;
        string nombreImagen = string.Empty;
        string nombreArcImagen = string.Empty;
        string textoEncriptado = string.Empty;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!txtClave.Text.Equals(string.Empty) && txtClave.Text.Length > 3)
            {
                blowfish b = new blowfish(this.txtClave.Text.ToString());
                if (this.tipo == false)
                {
                    this.txtEnc.Text = b.Encrypt_CBC(this.txtTextoPlano.Text.ToString());
                }
                else
                {
                    byte[] arreglo = conversionByteImg.ImageToByteArray(imagenAct);
                    string hex = BitConverter.ToString(conversionByteImg.ImageToByteArray(imagenAct));
                    this.textoEncriptado = b.Encrypt_CBC(hex);
                    if (guardaArchivo(this.rutaImagen, this.nombreImagen, this.textoEncriptado))
                    {
                        MessageBox.Show("el archivo txt se ha creado =)");
                    }
                    else
                    {
                        MessageBox.Show("el archivo txt no se ha creado");
                    }
                    tipo = false;
                    imagenAct = null;
                    rutaImagen = string.Empty;
                    nombreImagen = string.Empty;
                    nombreArcImagen = string.Empty;
                    textoEncriptado = string.Empty;
                    txtTextoPlano.Enabled = true;
                    txtEnc.Enabled = true;
                    pbImagen.Image = null;
                    btnEncriptar.Enabled = true;
                    btnDes.Enabled = true;
                    lblArchivo.Text = "Archivo: No seleccionado";
                }
            }
            else
            {
                MessageBox.Show("debes de introducir una clave valida, mayor a 3 digitos");
            }
        }

        private void btnDes_Click(object sender, EventArgs e)
        {
            if (!txtClave.Text.Equals(string.Empty) && txtClave.Text.Length > 3)
            {
                blowfish b = new blowfish(this.txtClave.Text.ToString());
                if (this.tipo == false)
                {
                    this.txtTextoPlano.Text = b.Decrypt_CBC(this.txtEnc.Text.ToString());
                }
                else
                {
                    if (leerArchivo())
                    {
                        string textoPlano = b.Decrypt_CBC(this.textoEncriptado);
                        string[] txt = textoPlano.Split('-');
                        byte[] array = new byte[txt.Length];
                        for (int i = 0; i < txt.Length; i++)
                        {
                            array[i] = Convert.ToByte(txt[i], 16);
                        }
                        try
                        {
                            imagenAct = conversionByteImg.ByteArrayToImage(array);
                            imagenAct.Save(this.rutaImagen + "\\" + nombreImagen + "(DES).jpg");
                            MessageBox.Show("La imagen se ha guardado con exito =)");
                        }
                        catch
                        {
                            MessageBox.Show("La imagen no se ha guardado con exito");
                        }
                    }
                    else
                    {
                        MessageBox.Show("El archivo no se pudo leer");
                    }

                    tipo = false;
                    imagenAct = null;
                    rutaImagen = string.Empty;
                    nombreImagen = string.Empty;
                    nombreArcImagen = string.Empty;
                    textoEncriptado = string.Empty;
                    txtTextoPlano.Enabled = true;
                    txtEnc.Enabled = true;
                    pbImagen.Image = null;
                    btnEncriptar.Enabled = true;
                    btnDes.Enabled = true;
                    lblArchivo.Text = "Archivo: No seleccionado";
                }
            }
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            OpenFileDialog archivoImg = new OpenFileDialog();
            archivoImg.FileName = "";
            if (DialogResult.OK == archivoImg.ShowDialog(this))
            {
                this.nombreArcImagen = archivoImg.FileName;
                if (Path.GetExtension(this.nombreArcImagen).Equals(".jpg"))
                {
                    tipo = true;
                    lblArchivo.Text = this.nombreArcImagen;
                    this.rutaImagen = Path.GetDirectoryName(this.nombreArcImagen);
                    this.nombreImagen = Path.GetFileNameWithoutExtension(this.nombreArcImagen);
                    pbImagen.Image = Image.FromFile(this.nombreArcImagen);
                    imagenAct = Image.FromFile(this.nombreArcImagen);
                    txtTextoPlano.Enabled = false;
                    txtEnc.Enabled = false;
                    btnEncriptar.Enabled = true;
                    btnDes.Enabled = false;
                }
                else
                {
                    MessageBox.Show("El archivo no es valido");
                }
            }
        }

        private bool guardaArchivo(string ruta, string nombre, string texto)
        {
            try
            {
                StreamWriter sw = new StreamWriter(ruta + "\\" + nombre + "(ENC).txt");
                sw.WriteLine(texto);
                sw.Dispose();
                return true;
            }
            catch
            {
                return false;
            }
        }

        private bool leerArchivo()
        {
            try
            {
                StreamReader sr = new StreamReader(this.nombreArcImagen);
                this.textoEncriptado = sr.ReadLine();
                sr.Dispose();
                return true;
            }
            catch
            {
                return false;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog archivoImg = new OpenFileDialog();
            archivoImg.FileName = "";
            if (DialogResult.OK == archivoImg.ShowDialog(this))
            {
                this.nombreArcImagen = archivoImg.FileName;
                if (Path.GetExtension(this.nombreArcImagen).Equals(".txt"))
                {
                    tipo = true;
                    lblArchivo.Text = this.nombreArcImagen;
                    this.rutaImagen = Path.GetDirectoryName(this.nombreArcImagen);
                    this.nombreImagen = Path.GetFileNameWithoutExtension(this.nombreArcImagen);
                    txtTextoPlano.Enabled = false;
                    txtEnc.Enabled = false;
                    btnEncriptar.Enabled = false;
                    btnDes.Enabled = true;
                }
                else
                {
                    MessageBox.Show("El archivo no es valido");
                }
            }
        }
    }
}
