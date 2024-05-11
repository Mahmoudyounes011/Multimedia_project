using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Main : Form
    {
        public Main()
        {
             InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            X_Ray x_ray = new X_Ray();
            x_ray.MdiParent = this;
            x_ray.Show();
        }

        private void file_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
