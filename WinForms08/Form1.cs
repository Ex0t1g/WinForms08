using System.Drawing.Drawing2D;

namespace WinForms08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Size = new Size(400, 400);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            int x = Math.Min(this.ClientSize.Height, this.ClientSize.Width); int y = x;
            g.FillEllipse(Brushes.GreenYellow, new Rectangle(x / 2, x / 4, y / 2, x * 10 / 15));
            g.FillEllipse(Brushes.GreenYellow, new Rectangle(y / 4, x / 4, y / 2, x * 10 / 15));


            g.FillPolygon(Brushes.SaddleBrown, new Point[] {
                new Point((y / 2 - y / 4) / 2 + y / 4 + x / 4, x / 4),
                new Point((y / 2 - y / 4) / 2 + y / 4 + y / 5, 0),
                new Point((y / 2 - y / 4) / 2 + y / 4 + y / 4, x / 50)
            });


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            Invalidate();
        }
    }
}