using System;
using System.Windows.Forms;
using System.Drawing;
public class Hello:Form
{
public Hello()
{
this.Paint += new PaintEventHandler(f1_paint);
}
private void f1_paint(object sender,PaintEventArgs e)
{
Graphics g = e.Graphics;
g.DrawString("Hello C#",new Font("Verdana",20),
new SolidBrush(Color.Tomato),40,40);
g.DrawRectangle(new Pen(Color.Pink,3),20,20,150,100);
}
public static void Main()
{
Application.Run(new Hello());
}
// End of class
}
