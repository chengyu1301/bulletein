using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bulletein
{
    public partial class Form2 : Form
    {
        bool lockState = false;
        Point startPoint;
        Form1 parentForm = null;
        bool allowResize = false;
        public Form2(Form1 f)
        {
            InitializeComponent();
            parentForm = f;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.Opacity = 0.01;
            this.ContextMenuStrip = parentForm.getContextMenuStrip();
            this.Left = 1030;
            this.Top = 100;
        }

        private void Form2_MouseDown(object sender, MouseEventArgs e)
        {
            startPoint = new Point(-e.X + SystemInformation.FrameBorderSize.Width, -e.Y - SystemInformation.FrameBorderSize.Height);
        }

        private void Form2_MouseMove(object sender, MouseEventArgs e)
        {

            if (parentForm.getLockState())
            {
                return;
            }



            if (e.Button == MouseButtons.Left)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(startPoint.X, startPoint.Y);
                this.Location = mousePos;
            }
        }

        private void Form2_Move(object sender, EventArgs e)
        {
            parentForm.setLocation(this.Location);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            allowResize = true;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (allowResize && !parentForm.getLockState())
            {
                this.Opacity = 0.3;
                this.Height = pictureBox1.Top + e.Y;
                this.Width = pictureBox1.Left + e.X;
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            allowResize = false;
            this.Opacity = 0.01;
        }

        private void Form2_MouseEnter(object sender, EventArgs e)
        {
            if (!parentForm.getLockState())
            {
                this.Opacity = 0.3;
            }
            GC.Collect();
        }

        private void Form2_MouseLeave(object sender, EventArgs e)
        {
            if (!parentForm.getLockState())
            {
                this.Opacity = 0.01;
            }
        }

        private void Form2_SizeChanged(object sender, EventArgs e)
        {
            parentForm.changeSize(this.Width, this.Height);
        }



    }
}
