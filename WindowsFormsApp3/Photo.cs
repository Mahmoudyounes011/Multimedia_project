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
    public partial class Photo : Form
    {
        public Photo()
        {
            InitializeComponent();
        }

        private void Photo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB1DataSet.Images' table. You can move, or remove it, as needed.
            this.imagesTableAdapter.Fill(this.dB1DataSet.Images);
            // TODO: This line of code loads data into the 'dB1DataSet.Images' table. You can move, or remove it, as needed.
            this.imagesTableAdapter.Fill(this.dB1DataSet.Images);

        }

        private void imagesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.imagesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dB1DataSet);

        }

        private void imagesBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.imagesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dB1DataSet);

        }

        private void dateDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void idTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void nameLabel_Click(object sender, EventArgs e)
        {

        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void pathLabel_Click(object sender, EventArgs e)
        {

        }

        private void pathTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void typeLabel_Click(object sender, EventArgs e)
        {

        }

        private void typeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateLabel_Click(object sender, EventArgs e)
        {

        }

        private void idLabel_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }

        private void Browse_Click(object sender, EventArgs e)
        {

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                image1.ImageLocation = openFileDialog1.FileName;
            }
        }

        private void image1_Click(object sender, EventArgs e)
        {

        }
    }
}
