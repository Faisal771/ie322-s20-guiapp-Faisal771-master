namespace Project_2
{
    partial class frmPic01
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
            this.btnLoadImage = new System.Windows.Forms.Button();
            this.BtnImageFromRes = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.picTry = new System.Windows.Forms.PictureBox();
            this.picTry2 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.picTry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTry2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLoadImage
            // 
            this.btnLoadImage.Location = new System.Drawing.Point(55, 37);
            this.btnLoadImage.Name = "btnLoadImage";
            this.btnLoadImage.Size = new System.Drawing.Size(121, 78);
            this.btnLoadImage.TabIndex = 0;
            this.btnLoadImage.Text = "Image from File";
            this.btnLoadImage.UseVisualStyleBackColor = true;
            this.btnLoadImage.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnImageFromRes
            // 
            this.BtnImageFromRes.Location = new System.Drawing.Point(55, 147);
            this.BtnImageFromRes.Name = "BtnImageFromRes";
            this.BtnImageFromRes.Size = new System.Drawing.Size(121, 84);
            this.BtnImageFromRes.TabIndex = 1;
            this.BtnImageFromRes.Text = "Image from Resource";
            this.BtnImageFromRes.UseVisualStyleBackColor = true;
            this.BtnImageFromRes.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(524, 456);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(128, 65);
            this.button3.TabIndex = 2;
            this.button3.Text = "Back";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // picTry
            // 
            this.picTry.Location = new System.Drawing.Point(6, 50);
            this.picTry.Name = "picTry";
            this.picTry.Size = new System.Drawing.Size(272, 282);
            this.picTry.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTry.TabIndex = 3;
            this.picTry.TabStop = false;
            this.picTry.Click += new System.EventHandler(this.picTry_Click);
            // 
            // picTry2
            // 
            this.picTry2.Location = new System.Drawing.Point(328, 47);
            this.picTry2.Name = "picTry2";
            this.picTry2.Size = new System.Drawing.Size(251, 285);
            this.picTry2.TabIndex = 4;
            this.picTry2.TabStop = false;
            this.picTry2.Click += new System.EventHandler(this.picTry2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.picTry);
            this.groupBox1.Controls.Add(this.picTry2);
            this.groupBox1.Location = new System.Drawing.Point(254, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(604, 355);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Picture Boxes";
            // 
            // frmPic01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 548);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.BtnImageFromRes);
            this.Controls.Add(this.btnLoadImage);
            this.Name = "frmPic01";
            this.Text = "frmPic01";
            this.Load += new System.EventHandler(this.frmPic01_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picTry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTry2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLoadImage;
        private System.Windows.Forms.Button BtnImageFromRes;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox picTry;
        private System.Windows.Forms.PictureBox picTry2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}