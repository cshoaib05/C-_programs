using System;
using System.Windows.Forms;
using System.Drawing;
public class Hello : Form
{
    public Hello()
    {
        this.Paint += new PaintEventHandler(f1_paint);
    }
    private void f1_paint(object sender, PaintEventArgs e)
    {
        Graphics g = e.Graphics;
        g.DrawString("Hello C#", new Font("Verdana", 20),
        new SolidBrush(Color.Tomato), 40, 40);
        g.DrawRectangle(new Pen(Color.Pink, 3), 20, 20, 150, 100);
    }
    public static void Main()
    {
        Application.Run(new Hello());
    }

    private Button button1;

    private void InitializeComponent()
    {
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(104, 59);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Hello
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.button1);
            this.Name = "Hello";
            this.ResumeLayout(false);

    }

    private void button1_Click(object sender, EventArgs e)
    {
        System.Drawing.Graphics graphicsObj;

        graphicsObj = this.CreateGraphics();

        Pen myPen = new Pen(System.Drawing.Color.Red, 5);

        graphicsObj.DrawLine(myPen, 20, 20, 200, 20);
    }
    // End of class
}