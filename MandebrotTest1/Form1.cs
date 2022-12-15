namespace MandebrotTest1
{
    public partial class Mandelbrot : Form
    {
        int scaleFactor = 1000;

        public Mandelbrot()
        {
            InitializeComponent();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            Bitmap bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);

            for (int x = 0; x < bitmap.Width; x++)
            {
                for (int y = 0; y < bitmap.Height; y++)
                {
                    double a = (double)(x - (pictureBox1.Width / 2)) / (double)(pictureBox1.Width / 4);
                    double b = (double)(y - (pictureBox1.Height / 2)) / (double)(pictureBox1.Height / 4);
                    Complex c = new Complex(a, b);
                    Complex z = new Complex(0, 0);
                    int it = 0;
                    do
                    {
                        it++;
                        z.Square();
                        z.Add(c);
                        if (z.Magnitude() > 20.0) break;
                    }
                    while (it < 2100);
                    bitmap.SetPixel(x, y, it < 2100 ? Color.Black: Color.White);
                }
            }
            pictureBox1.Image = bitmap;
        }

        private void ZoomInButton_Click(object sender, EventArgs e)
        {
            pictureBox1.Height += scaleFactor;
            pictureBox1.Width += scaleFactor;
        }

        private void ZoomOutButton_Click(object sender, EventArgs e)
        {
            pictureBox1.Height -= scaleFactor;
            pictureBox1.Width -= scaleFactor;
        }
    }
}