using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;

namespace MagicGraphics
{
    public partial class Form1 : Form
    {
        Display d;

        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Vector center = new Vector(pictureBox1.Width / 2, pictureBox1.Height / 2);
            d = new Display(0.02f, center, pictureBox1.CreateGraphics());

            Vector[] vs = {
                new Vector(1,1),
                new Vector(1,-1),
                new Vector(-1,-1),
                new Vector(-1,1)
            };

            d.connectPoints(vs);
        }
    }
}
