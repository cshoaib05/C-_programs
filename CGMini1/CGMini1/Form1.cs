using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CGMini1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var x1 = Convert.ToInt32(textBox1.Text);
            var x2 = Convert.ToInt32(textBox2.Text);
            var y1 = Convert.ToInt32(textBox3.Text);
            var y2 = Convert.ToInt32(textBox4.Text);


            draw_Line(x1,x2,y1,y2);
        }

        public void draw_Line(int x1,int x2, int y1,int y2)
        {

            System.Drawing.Graphics graphicsObj;

            graphicsObj = this.CreateGraphics();

            Pen myPen = new Pen(System.Drawing.Color.Red, 1);

            graphicsObj.DrawLine(myPen, x1, y1, x2, y2);
        }

    }
}
