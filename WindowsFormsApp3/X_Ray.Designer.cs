
namespace WindowsFormsApp3
{
    partial class X_Ray
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.image1 = new System.Windows.Forms.PictureBox();
            this.Browse = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Path = new System.Windows.Forms.TextBox();
            this.image2 = new System.Windows.Forms.PictureBox();
            this.Save = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.image1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.image2)).BeginInit();
            this.SuspendLayout();
            // 
            // image1
            // 
            this.image1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.image1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.image1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.image1.Location = new System.Drawing.Point(67, 44);
            this.image1.Name = "image1";
            this.image1.Size = new System.Drawing.Size(189, 185);
            this.image1.TabIndex = 9;
            this.image1.TabStop = false;
            this.image1.Tag = "image1";
            this.image1.Click += new System.EventHandler(this.image1_Click);
            this.image1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.image1_MouseDown);
            this.image1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.image1_MouseMove);
            this.image1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.image1_MouseUp);
            // 
            // Browse
            // 
            this.Browse.Location = new System.Drawing.Point(67, 275);
            this.Browse.Name = "Browse";
            this.Browse.Size = new System.Drawing.Size(75, 23);
            this.Browse.TabIndex = 7;
            this.Browse.Tag = "Browse";
            this.Browse.Text = "Browse";
            this.Browse.UseVisualStyleBackColor = true;
            this.Browse.Click += new System.EventHandler(this.Browse_Click_1);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Images|*.jpg;*.jpeg;*.png;*.bmp";
            this.openFileDialog1.InitialDirectory = "D:\\";
            this.openFileDialog1.Title = "Browse image";
            // 
            // Path
            // 
            this.Path.Location = new System.Drawing.Point(164, 278);
            this.Path.Name = "Path";
            this.Path.Size = new System.Drawing.Size(228, 20);
            this.Path.TabIndex = 10;
            this.Path.TextChanged += new System.EventHandler(this.Path_TextChanged);
            // 
            // image2
            // 
            this.image2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.image2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.image2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.image2.Location = new System.Drawing.Point(300, 44);
            this.image2.Name = "image2";
            this.image2.Size = new System.Drawing.Size(189, 185);
            this.image2.TabIndex = 11;
            this.image2.TabStop = false;
            this.image2.Tag = "image2";
            this.image2.Click += new System.EventHandler(this.image2_Click);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(414, 275);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 23);
            this.Save.TabIndex = 12;
            this.Save.Tag = "Browse";
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // X_Ray
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 450);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.image2);
            this.Controls.Add(this.Path);
            this.Controls.Add(this.image1);
            this.Controls.Add(this.Browse);
            this.Name = "X_Ray";
            this.Text = "X_Ray";
            ((System.ComponentModel.ISupportInitialize)(this.image1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.image2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox image1;
        private System.Windows.Forms.Button Browse;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox Path;
        private System.Windows.Forms.PictureBox image2;
        private System.Windows.Forms.Button Save;
    }
}