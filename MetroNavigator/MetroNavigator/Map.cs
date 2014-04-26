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
        Rectangle KitayGorod;
        Size size;

        public Map()
        {
            InitializeComponent();
            size = pictureBox1.Size;
            KitayGorod = new Rectangle(new Point((int)(pictureBox1.Location.X + pictureBox1.Width / 1.7),
                (int)(pictureBox1.Location.Y + pictureBox1.Height / 2.063)),
                new Size(32, 15));
        }


        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            pictureBox1.Location = new Point((int)((-hScrollBar1.Value) * deltaX), (int)((-vScrollBar1.Value) * deltaY));
            KitayGorod.Location = new Point((int)(pictureBox1.Location.X + pictureBox1.Width / 1.7),
                (int)(pictureBox1.Location.Y + pictureBox1.Height / 2.063));
            KitayGorod.Size = new Size((int)(pictureBox1.Width / 12.59), (int)(pictureBox1.Height / 41.4));
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            pictureBox1.Location = new Point((int)((-hScrollBar1.Value) * deltaX), (int)((-vScrollBar1.Value) * deltaY));
            KitayGorod.Location = new Point((int)(pictureBox1.Location.X + pictureBox1.Width / 1.7),
                (int)(pictureBox1.Location.Y + pictureBox1.Height / 2.063));
            KitayGorod.Size = new Size((int)(pictureBox1.Width / 12.59), (int)(pictureBox1.Height / 41.4));
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            pictureBox1.Size = new Size(size.Width + trackBar1.Value*50,
                size.Height + trackBar1.Value*50);

            deltaY = (pictureBox1.Size.Height - size.Height) / 100f;
            deltaX = (pictureBox1.Size.Width - size.Width) / 100f;
            pictureBox1.Location = new Point((int)((-hScrollBar1.Value) * deltaX), (int)((-vScrollBar1.Value) * deltaY));
            KitayGorod.Location = new Point((int)(pictureBox1.Location.X + pictureBox1.Width / 1.7),
                (int)(pictureBox1.Location.Y + pictureBox1.Height / 2.063));
            KitayGorod.Size = new Size((int)(pictureBox1.Width / 12.59), (int)(pictureBox1.Height / 41.4));

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Point x =  PointToClient(MousePosition);
            if (x.X < KitayGorod.X + KitayGorod.Width && x.X > KitayGorod.X && x.Y < KitayGorod.Y + KitayGorod.Height && x.Y > KitayGorod.Y)
            {
                MessageBox.Show(x.X+" "+x.Y+"      "+KitayGorod.X+" "+KitayGorod.Y);

            }
        }
    }
}
