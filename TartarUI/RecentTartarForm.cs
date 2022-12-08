using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TartarUI
{
    public partial class RecentTartarForm : Form
    {
        public RecentTartarForm()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void RecentTartarForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            
            if (this.pictureBox1.Image != null)
            {
                try
                {
                    Bitmap bitmap = new Bitmap(this.pictureBox1.Image);
                    Color color = bitmap.GetPixel(e.X, e.Y);
                    this.label1.Text = $"RED : {color.R} GREEN : {color.G} BLUE : {color.B}";
                }
                catch (Exception)
                {
                }
               
            }
           
        }
       

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           // if (this.pictureBox1.Image != null)
            //{
              //  try
                //{
                  //  Bitmap bitmap = new Bitmap(this.pictureBox1.Image);
                    //Color color = bitmap.GetPixel(e.X, e.Y);
                    //string gum = color.R >= 2 && color.G <= 20;
                    //string tooth = color.R <= 1 && color.G >= 19;
                //}
                //catch (Exception)
               // {
                //}
            }
    }
        }

        
   

