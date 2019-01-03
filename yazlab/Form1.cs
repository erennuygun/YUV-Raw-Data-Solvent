//Mehmet Akif ALTINOK - 160201029
//Muhammed Eren UYGUN - 160201064
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

namespace yazlab
{
    public partial class ana_menu : Form
    {
        public int index = 0;
        public Bitmap bm;
        public List<Bitmap> l = new List<Bitmap>();
        public int pi = 0;

        public ana_menu()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {    
            try
            {
                int width = Convert.ToInt32(txtW.Text);
                int height = Convert.ToInt32(txtH.Text);
                Size s1 = new Size(width, height);
                pictureBox.Size = s1;
                int frameSize = 0;
                if (comboBox1.SelectedItem.ToString() == "4-4-4")
                {
                    frameSize = width * height * 3;
                }
                if (comboBox1.SelectedItem.ToString() == "4-2-2")
                {
                    frameSize = width * height * 2;
                }
                if (comboBox1.SelectedItem.ToString() == "4-2-0")
                {
                    frameSize = width * height + (width * height) / 2;
                }
                int imgSize = width * height;
                byte[] yuv = new byte[frameSize];
                byte[] rgb = new byte[3 * imgSize];
                byte[] y = new byte[imgSize];
                using (FileStream fs = File.OpenRead(textBox1.Text))
                {
                    int frame = (int)fs.Length / frameSize;
                    using (BinaryReader br = new BinaryReader(fs))
                    {
                        while (br.PeekChar() != -1)
                        {
                            br.Read(yuv, 0, frameSize);
                            bm = YUVtoRGB(yuv, rgb, width, height);
                            l.Add(bm);
                            ımageList1.Images.Add(bm);
                            index++;
                        }
                    }
                }
                System.Windows.Forms.MessageBox.Show("Okuma işlemi başarılı!");
                oynat.Enabled = true;
                durdur.Enabled = true;
                bmp_kaydet.Enabled = true; 
            }
            catch {
                System.Windows.Forms.MessageBox.Show("Lütfen Formatları Doğru Girin");
                ımageList1.Images.Clear();
                index = 0;
            }
        }
        static Bitmap YUVtoRGB(byte[] y, byte[] rgbFrame, int width, int height)
        {
            int gIndex = width * height;
            int bIndex = gIndex * 2;
            int temp = 0;
            Bitmap bm = new Bitmap(width, height);
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    // R
                    temp = (int)((y[i * width + j]) * 1.4022);
                    rgbFrame[i * width + j] = (byte)(temp < 0 ? 0 : (temp > 255 ? 255 : temp));
                    // G
                    temp = (int)((y[i * width + j]) * -0.3456);
                    rgbFrame[gIndex + i * width + j] = (byte)(temp < 0 ? 0 : (temp > 255 ? 255 : temp));
                    // B
                    temp = (int)((y[i * width + j] ) * 1.771);
                    rgbFrame[bIndex + i * width + j] = (byte)(temp < 0 ? 0 : (temp > 255 ? 255 : temp));
                    //Pixel yazdir
                    Color c = Color.FromArgb(rgbFrame[i * width + j], rgbFrame[i * width + j], rgbFrame[i * width + j]);
                    bm.SetPixel(j, i, c);
                }
            }
            return bm;
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pi < index)
            {
                pictureBox.Image = ımageList1.Images[pi];
                pi++;
            }
            else
            {
                timer1.Stop();
                pi = 0;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            textBox1.Text = openFileDialog1.FileName;
            string a = textBox1.Text;
            if (a.Substring(a.Length - 4, 4) != ".yuv")
            {
                System.Windows.Forms.MessageBox.Show("Lütfen YUV formatı seçiniz");
                textBox1.Clear();
            }
            else
            {
                dosyadan_oku.Enabled = true;
                button2.Enabled = false;
                sifirla.Enabled = true;
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < index; i++)
            {
                l[i].Save(@"bmp\a" + i + ".bmp");
            }
            System.Windows.Forms.MessageBox.Show("Kayıt İşlemi Tamamlandı");
        }
        private void button3_Click_1(object sender, EventArgs e)
        {
            {
                timer1.Enabled = true;
                timer1.Start();
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
        private void txtW_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        private void txtH_KeyPress(object sender, KeyPressEventArgs e)
        { 
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            } 
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        private void sifirla_Click(object sender, EventArgs e)
        {
            index = 0;
            timer1.Stop();
            pi = 0;
            ımageList1.Images.Clear();
            txtW.Clear();
            txtH.Clear();
            bmp_kaydet.Enabled = false;
            oynat.Enabled = false;
            durdur.Enabled = false;
            dosyadan_oku.Enabled = false;
            pictureBox.Image = null;
            comboBox1.SelectedItem = null;
            textBox1.Clear();
            button2.Enabled = true;
            sifirla.Enabled = false;
            l.Clear();
        }
    }
}