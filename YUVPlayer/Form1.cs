using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YUVPlayer
{
    public partial class Form1 : Form
    {
        OpenFileDialog openFileDialog1;
        static String path;
        int frameSize;
        int playVideoCounter = 0;
        int createYuvCounter = 0;
        Timer T;
        public Form1()
        {
            InitializeComponent();
            openFileDialog1 = new OpenFileDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pathTB.Text = openFileDialog1.FileName;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int parsedValue;
            if (!int.TryParse(widthTB.Text, out parsedValue))
            {
                MessageBox.Show("Width value must be integer.");
                return;
            }
            if(!int.TryParse(heightTB.Text, out parsedValue))
            {
                MessageBox.Show("Height value must be integer.");
                return;
            }
            if(pathTB.Text == "")
            {
                MessageBox.Show("Please select your .yuv file.");
                return;
            }
            if(!pathTB.Text.Substring(pathTB.Text.Length - 3).Equals("yuv"))
            {
                MessageBox.Show("Selected file extension must be .yuv");
                return;
            }

            if (System.IO.Directory.Exists("frames"))
            {
                System.IO.DirectoryInfo di = new DirectoryInfo("frames");

                foreach (FileInfo file in di.GetFiles())
                {
                    file.Delete();
                }
                foreach (DirectoryInfo dir in di.GetDirectories())
                {
                    dir.Delete(true);
                }
            }
            createYuvCounter++;
            renderParse();
        }

        public void playVideo(object sender, EventArgs e)
        {
            Console.WriteLine(playVideoCounter);
            if(playVideoCounter < frameSize)
            {
                FileStream fs = new System.IO.FileStream("frames\\myFile" + playVideoCounter + ".bmp", FileMode.Open, FileAccess.Read);
                pictureBox1.Image = Image.FromStream(fs);
                fs.Close();
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;   
            }
            else
            {
                T.Stop();
                playVideoCounter = 0;
            }
            playVideoCounter++;   
        }

        public void renderParse()
        {
            path = pathTB.Text;
            Form1 form = new Form1();

            if (!System.IO.Directory.Exists("frames"))
            {
                System.IO.Directory.CreateDirectory("frames");
            }

            FileStream fs;
            try
            {
                fs = new FileStream(path, FileMode.Open, FileAccess.Read);
            }
            catch(FileNotFoundException e)
            {
                MessageBox.Show("File not found!");
                return;
            }
            BinaryReader br = new BinaryReader(fs);
            long readedNum = new FileInfo(path).Length;
            byte[] bytes = br.ReadBytes((int)readedNum);
            int w = Convert.ToInt32(widthTB.Text);
            int h = Convert.ToInt32(heightTB.Text);
            long resolution = w * h;
            double multiplier = 3;

            byte[] r = new byte[resolution];
            byte[] g = new byte[resolution];
            byte[] b = new byte[resolution];

            long jumpValue = 0;
            if (radio444.Checked)
            {
                jumpValue = 2 * (resolution);
                multiplier = 3;
            }else if (radio422.Checked)
            {
                jumpValue = resolution;
                multiplier = 2;
            }else if (radio420.Checked)
            {
                jumpValue = resolution / 2;
                multiplier = 1.5;
            }
            frameSize = bytes.Length / (int)(resolution * multiplier);
            Console.WriteLine("Byte length = " + bytes.Length);
            Console.WriteLine("Jump value: " + jumpValue);
            Console.WriteLine("Frame : " + frameSize);

            int counter = 0;
            int fileNameCounter = 0;
            bool flag420 = true;

            List<String> fileNames = new List<String>();

            for (long i = 1; i <= bytes.Length; i++)
            {
                r[counter] = (byte)(1.164 * (bytes[i-1] - 16));
                g[counter] = (byte)(1.164 * (bytes[i-1] - 16));
                b[counter] = (byte)(1.164 * (bytes[i-1] - 16));
                if(i % resolution == 0 && !radio420.Checked)
                {
                    Bitmap pic = new Bitmap(w, h, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
                    Color c;

                    for (int j = 0; j < r.Length; j++)
                    {
                        c = Color.FromArgb(r[j], g[j], b[j]);
                        pic.SetPixel(j % w, j / w, c);
                    }
                    fileNames.Add("frames\\myfile" + fileNameCounter + ".bmp");
                    pic.Save("frames\\myfile" + fileNameCounter+".bmp", ImageFormat.Bmp);

                    fileNameCounter++;
                    counter = 0;
                    i = i + jumpValue;
                    continue;
                }else if (radio420.Checked)
                {
                    if (flag420 && (i % resolution == 0))
                    {
                        Bitmap pic = new Bitmap(w, h, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
                        Color c;

                        for (int j = 0; j < r.Length; j++)
                        {
                            c = Color.FromArgb(r[j], g[j], b[j]);
                            pic.SetPixel(j % w, j / w, c);
                        }
                        pic.Save("frames\\myfile" + fileNameCounter + ".bmp", ImageFormat.Bmp);
                        fileNames.Add("myfile" + fileNameCounter + ".bmp");
                        fileNameCounter++;
                        counter = 0;
                        i = i + jumpValue;
                        flag420 = false;
                        continue;
                    }else if(!flag420 && (i % resolution == resolution / 2))
                    {
                        Bitmap pic = new Bitmap(w, h, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
                        Color c;

                        for (int j = 0; j < r.Length; j++)
                        {
                            c = Color.FromArgb(r[j], g[j], b[j]);
                            pic.SetPixel(j % w, j / w, c);
                        }
                        pic.Save("frames\\myfile" + fileNameCounter + ".bmp", ImageFormat.Bmp);
                        fileNames.Add("myfile" + fileNameCounter + ".bmp");
                        fileNameCounter++;
                        counter = 0;
                        i = i + jumpValue;
                        flag420 = true;
                        continue;
                    }
                }
                counter++;
            }
            

            T = new Timer();
            T.Interval = 90;
            T.Tick += new EventHandler(playVideo);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.Image = Image.FromFile("play.png");
            br.Close();
            fs.Close();
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            T.Start();
        }

        private void stopBtn_Click(object sender, EventArgs e)
        {
            T.Stop();
            playVideoCounter = 0;
        }
    }
}
