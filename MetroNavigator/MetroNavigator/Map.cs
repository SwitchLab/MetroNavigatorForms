using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MetroNavigator
{
    public partial class Map : Form
    {
        double deltaY = 6;
        double deltaX = 7;

        Size size;

        public Map()
        {
            InitializeComponent();
            size = pictureBox1.Size;
        }


        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            pictureBox1.Location = new Point((int)((-hScrollBar1.Value) * deltaX), (int)((-vScrollBar1.Value) * deltaY));
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            pictureBox1.Location = new Point((int)((-hScrollBar1.Value) * deltaX), (int)((-vScrollBar1.Value) * deltaY));
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            pictureBox1.Size = new Size(size.Width + trackBar1.Value*50,
                size.Height + trackBar1.Value*50);

            deltaY = (pictureBox1.Size.Height - size.Height) / 100f;
            deltaX = (pictureBox1.Size.Width - size.Width) / 100f;
            pictureBox1.Location = new Point((int)((-hScrollBar1.Value) * deltaX), (int)((-vScrollBar1.Value) * deltaY));
        }
    }
}
