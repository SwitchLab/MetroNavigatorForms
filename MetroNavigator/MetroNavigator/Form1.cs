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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void navigationButton_Click(object sender, EventArgs e)
        {
            Map map = new Map();
            this.Visible = false;
            map.Show();
            map.FormClosed += new FormClosedEventHandler(map_FormClosed);
        }
        private void map_FormClosed(object sender, EventArgs e)
        {
            this.Visible = true;
        }
    }
}
