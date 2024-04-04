namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left && pictureBox1.Left > 0)
            {
                pictureBox1.Left -= 10;
            }

            if (e.KeyCode == Keys.Right && pictureBox1.Right < ClientSize.Width)
            {
                pictureBox1.Left += 10;
            }

            if (e.KeyCode == Keys.Up && pictureBox1.Top > 0)
            {
                pictureBox1.Top -= 10;
            }

            if (e.KeyCode == Keys.Down && pictureBox1.Bottom < ClientSize.Height)
            {
                pictureBox1.Top += 10;
            }
        }
    }
}