using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageProccess
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.resim1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.resim2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.resim3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = textBox1.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pictureBox1.Image= Image.FromFile(textBox2.Text);

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (listBox1.SelectedIndex != -1)
            {
                if (listBox1.SelectedIndex == 0)
                {
                    pictureBox1.Image = Properties.Resources.resim1;
                }
                else if (listBox1.SelectedIndex == 1)
                {
                    pictureBox1.Image = Properties.Resources.resim2;
                }
                else if (listBox1.SelectedIndex == 2)
                {
                    pictureBox1.Image = Properties.Resources.resim3;
                }

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK) 
            {
                pictureBox1.ImageLocation = openFileDialog.FileName;

                string name=openFileDialog.FileName;
                string[] filename = name.Split('\\');
                label3.Text = "SelectedImage: " + filename[filename.Length -1];
            }
            else
            {
                MessageBox.Show("Seçim iptal edildi");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string imagesPath = @"C:\Users\iarif\OneDrive\Masaüstü\imgs\";
           
             pictureBox1.Image.Save(imagesPath + Guid.NewGuid() + ".jpg", ImageFormat.Jpeg);
           
            
               
        }

        private void button8_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = openFileDialog.FileName;

                string name = openFileDialog.FileName;
                string[] filename = name.Split('\\');
                label3.Text = "SelectedImage: " + filename[filename.Length - 1];


            }


            else
            {
                MessageBox.Show("Seçim iptal edildi");
            }
        }
    }
}
