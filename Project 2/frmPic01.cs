using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;            //for stream object
using System.Reflection;    // for assembly

namespace Project_2
{
    public partial class frmPic01 : Form
    {

        Assembly _assembly;   //creating an assembly object
        Stream _imageStream;   // create an image stream object


        


        public frmPic01()
        {
            InitializeComponent();


            //controls the clipping and positioning of the image in the display area.
            picTry.SizeMode = PictureBoxSizeMode.StretchImage;
            picTry2.SizeMode = PictureBoxSizeMode.StretchImage;

            
                
        }

        private void button1_Click(object sender, EventArgs e)
        {

                 try
            {
                // picTry.Image = Image.FromFile("I:\\DrAtif_IE_KAU\\20180322\\IE322_S18_KAU\\IE322_S18_KAU\\res\\A.jpg");
                // picTry.Image = Image.FromFile("C: \\Users\\Public\\Pictures\\Sample Pictures\\Koala.jpg"); // This may not work if you change the computer, Then you have to change this line

                // picTry.Image = Image.FromFile("G:\\IE322_ALL\\_IE322_S20\\20180404\\tiny_cc_jaixjz.png"); //absolute path

                picTry.Image = Image.FromFile("C:\\Users\\Lenovo\\Pictures\\Smiley face.jpg"); // relative path
            }
            catch
            {
                MessageBox.Show("Image file not found!");
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                picTry2.Image = Image.FromStream(_imageStream);

            }
            catch
            {
                MessageBox.Show("Error creating image!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void picTry_Click(object sender, EventArgs e)
        {


            //MessageBox.Show("Coordinates are: " + coordinates);

        } 

        private void frmPic01_Load(object sender, EventArgs e)
        {
            _assembly = Assembly.GetExecutingAssembly(); //set the assembly object
            _imageStream = _assembly.GetManifestResourceStream("Project_2.res.KAU Symbol.png");
            
        }

        private void picTry2_Click(object sender, EventArgs e)
        {

        }
    }
}
