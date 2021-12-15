using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;

namespace segmentacion
{
    public partial class index : System.Web.UI.Page
    {
        int cR, cG, cB;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int tamanio = fuploadImagen.PostedFile.ContentLength;
            byte [] ImagenOriginal = new byte [tamanio];
            fuploadImagen.PostedFile.InputStream.Read(ImagenOriginal,0,tamanio);
            Bitmap ImagenOriginalBinaria = new Bitmap(fuploadImagen.PostedFile.InputStream);
            string ImagenDataURL64 = "data:image/jpg;base64," + Convert.ToBase64String(ImagenOriginal);
            Image1.ImageUrl = ImagenDataURL64;
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            Bitmap ImagenOriginalBinaria = new Bitmap(fuploadImagen.PostedFile.InputStream);
            Bitmap cpoa = new Bitmap(fuploadImagen.PostedFile.InputStream);
            Color c = new Color();
            for (int i = 1; i < ImagenOriginalBinaria.Width; i++)
                for (int j = 1; j < ImagenOriginalBinaria.Height; j++)
                {
                    c = ImagenOriginalBinaria.GetPixel(i, j);
                    cpoa.SetPixel(i, j, c);
                }
            Image2.ImageUrl = Image1.ImageUrl;
           
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            
            Bitmap bmp = new Bitmap(Image1.ImageUrl);
            Color c = new Color();
            c = bmp.GetPixel(10, 10);
            TextBox2.Text = c.R.ToString();
            //textBox2.Text = c.G.ToString();
            TextBox4.Text = c.B.ToString();
        }

       

      
       

        protected void Button3_Click(object sender, EventArgs e)
        {
            int meR, meG, meB;
            Bitmap bmp = new Bitmap(Image1.ImageUrl);
            Bitmap cpoa = new Bitmap(bmp.Width, bmp.Height);
            Color c = new Color();
            for (int i = 0; i < bmp.Width - 10; i += 10)
                for (int j = 0; j < bmp.Height - 10; j += 10)
                {
                    meR = 0;
                    meG = 0;
                    meB = 0;

                    for (int k = i; k < i + 10; k++)
                        for (int l = j; l < j + 10; l++)
                        {
                            c = bmp.GetPixel(k, l);
                            meR = meR + c.R;
                            meG = meG + c.G;
                            meB = meB + c.B;
                        }
                    meR = meR / 100;
                    meG = meG / 100;
                    meB = meB / 100;

                    if (((cR - 10) < meR) && (meR < (cR + 10)) && ((cG - 10) < meG) && (meG < (cG + 10)) && ((cB - 10) < meB) && (meB < (cB + 10)))
                        for (int k = i; k < i + 10; k++)
                            for (int l = j; l < j + 10; l++)
                            {
                                cpoa.SetPixel(k, l, Color.Green);

                            }

                    else
                        for (int k = i; k < i + 10; k++)
                            for (int l = j; l < j + 10; l++)
                            {
                                c = bmp.GetPixel(k, l);
                                cpoa.SetPixel(k, l, c);
                            }
                }
        }

        

        protected void Button4_Click(object sender, EventArgs e)
        {
            int meR, meG, meB;
            Bitmap bmp = new Bitmap(Image1.ImageUrl);
            Bitmap cpoa = new Bitmap(bmp.Width, bmp.Height);
            Color c = new Color();
            for (int i = 0; i < bmp.Width - 10; i += 10)
                for (int j = 0; j < bmp.Height - 10; j += 10)
                {
                    meR = 0;
                    meG = 0;
                    meB = 0;

                    for (int k = i; k < i + 10; k++)
                        for (int l = j; l < j + 10; l++)
                        {
                            c = bmp.GetPixel(k, l);
                            meR = meR + c.R;
                            meG = meG + c.G;
                            meB = meB + c.B;
                        }
                    meR = meR / 100;
                    meG = meG / 100;
                    meB = meB / 100;

                    if (((cR - 10) < meR) && (meR < (cR + 10)) && ((cG - 10) < meG) && (meG < (cG + 10)) && ((cB - 10) < meB) && (meB < (cB + 10)))
                        for (int k = i; k < i + 10; k++)
                            for (int l = j; l < j + 10; l++)
                            {
                                cpoa.SetPixel(k, l, Color.Green);

                            }

                    else
                        for (int k = i; k < i + 10; k++)
                            for (int l = j; l < j + 10; l++)
                            {
                                c = bmp.GetPixel(k, l);
                                cpoa.SetPixel(k, l, c);
                            }
                }
            
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            int meR, meG, meB;
            Bitmap bmp = new Bitmap(Image1.ImageUrl);
            Bitmap cpoa = new Bitmap(bmp.Width, bmp.Height);
            Color c = new Color();
            for (int i = 0; i < bmp.Width - 10; i += 10)
                for (int j = 0; j < bmp.Height - 10; j += 10)
                {
                    meR = 0;
                    meG = 0;
                    meB = 0;

                    for (int k = i; k < i + 10; k++)
                        for (int l = j; l < j + 10; l++)
                        {
                            c = bmp.GetPixel(k, l);
                            meR = meR + c.R;
                            meG = meG + c.G;
                            meB = meB + c.B;
                        }
                    meR = meR / 100;
                    meG = meG / 100;
                    meB = meB / 100;

                    if (((cR - 10) < meR) && (meR < (cR + 10)) && ((cG - 10) < meG) && (meG < (cG + 10)) && ((cB - 10) < meB) && (meB < (cB + 10)))
                        for (int k = i; k < i + 10; k++)
                            for (int l = j; l < j + 10; l++)
                            {
                                cpoa.SetPixel(k, l, Color.Green);

                            }

                    else
                        for (int k = i; k < i + 10; k++)
                            for (int l = j; l < j + 10; l++)
                            {
                                c = bmp.GetPixel(k, l);
                                cpoa.SetPixel(k, l, c);
                            }
                }
            
        }

        protected void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button7_Click(object sender, EventArgs e)
        {

        }

    }
}