using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lo_Fi_Radio
{
    public partial class Init_Form : Form
    {

        public Init_Form()
        {
            InitializeComponent();
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = Color.Transparent;
        }
        protected override void OnPaintBackground(PaintEventArgs e) { }
        private void Init_Form_Load(object sender, EventArgs e)
        {
            pictureBox1.Size = pictureBox1.Image.Size;
            this.Opacity = 0.1;
            FadeIn_Timer.Start();
        }

        private void FadeIn_Timer_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1.0)
            {
                this.Opacity += 0.025;
            }
            else
            {
                FadeIn_Timer.Stop();
                Load_Timer.Start();
            }
        }

        private void Load_Timer_Tick(object sender, EventArgs e)
        {
            Load_Timer.Stop();
            FadeOut_Timer.Start();
        }

        private void FadeOut_Timer_Tick(object sender, EventArgs e)
        {

            if (this.Opacity >= 0.1)
            {
                this.Opacity -= 0.025;
            }
            else
            {
                FadeOut_Timer.Stop();
                this.Close();
            }
        }
    }
}
