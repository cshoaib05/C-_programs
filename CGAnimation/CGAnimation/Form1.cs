using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CGAnimation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void controller1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Paint += Form1_Paint;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
           
            e.Graphics.DrawRectangle(Pens.Black, new Rectangle(0, 0, 500, 500));
            e.Graphics.FillRectangle(Brushes.Blue, new Rectangle(0, 0, 500, 500));
            e.Graphics.FillEllipse(Brushes.Yellow, new Rectangle(50, 50, 120, 120));
        }
    }
}
