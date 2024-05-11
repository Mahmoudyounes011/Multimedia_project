using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
namespace WindowsFormsApp3
{
    public partial class X_Ray : Form
    {
        Bitmap bm;
        Graphics g;
        bool paint = false;
        Point px, py;
        Pen p = new Pen(Color.Black, 1);
        int select;
        Color newcolor;
     
        public X_Ray()
        {
            InitializeComponent();
        }

  
        private void Browse_Click_1(object sender, EventArgs e)
        {
          
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                image1.ImageLocation = openFileDialog1.FileName;
                Path_TextChanged(sender , e);
            }
        }

        private void image1_Click(object sender, EventArgs e)
        {

        }

        private void Path_TextChanged(object sender, EventArgs e)
        {
            Path.Text = image1.ImageLocation;
        }

        private void Save_Click(object sender, EventArgs e)
        {
            image2_Click(sender, e);
        }

        private void image1_MouseDown(object sender, MouseEventArgs e)
        {
            paint = true;

        }

        private void image1_MouseMove(object sender, MouseEventArgs e)
        {
            if()
        }

        private void image1_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void image2_Click(object sender, EventArgs e)
        {
            Bitmap image = new Bitmap(image1.ImageLocation);
            image.Save("D:\\project\\new.jpg");
            image2.ImageLocation = "D:\\project\\new.jpg";
            image2.Show();
        }
    }

}