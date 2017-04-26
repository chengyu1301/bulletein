using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace bulletein
{
    public partial class Form1 : Form
    {
        private Point startPoint;
        bool lockstate = false;
        Form3 f = null;
        Form2 board;

        private FontStyle fontStyle;
        private FontFamily fontFamily;
        private float fontSize;
        private bool timerMode = false;
        private string tmpMsg = "";

        private const uint WS_EX_LAYERED = 0x80000;

        private const int WS_EX_TRANSPARENT = 0x20;

        private const int GWL_STYLE = (-16);

        private const int GWL_EXSTYLE = (-20);

        private const int LWA_ALPHA = 0;


        [DllImport("user32", EntryPoint = "SetWindowLong")]
        private static extern uint SetWindowLong(IntPtr hwnd, int nIndex, uint dwNewLong);

        [DllImport("user32", EntryPoint = "GetWindowLong")]
        private static extern uint GetWindowLong(IntPtr hwnd, int nIndex);



        public Form1()
        {

            /*
            Process[] ps = Process.GetProcessesByName(Process.GetCurrentProcess().ProcessName);
            if (ps.Length > 1)
            {
                MessageBox.Show("Another process is running, please terminate it first!");
                //this.Close();
                Environment.Exit(Environment.ExitCode);
            }
            */

            InitializeComponent();
           
        }

        private void getFont()
        {
            fontStyle = labelPromptString.Font.Style;
            fontFamily = labelPromptString.Font.FontFamily;
            fontSize = labelPromptString.Font.Size;
        }







        public void setMessage(string msg)
        {
            labelPromptString.Text = msg;
        }




        private void 離開ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void 紅色ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            updateColor("Red");
        }

        private void 藍色ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            updateColor("Blue");
        }

        private void 黑色ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            updateColor("Black");
        }

        private void 白色ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            updateColor("White");
        }

        private void 黃色ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            updateColor("Yellow");
        }

        private void 綠色ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            updateColor("Green");
        }

        private void lockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lockstate)
            {
                lockToolStripMenuItem.Text = "Lock";
                board.Opacity = 0.01;
            }
            else
            {
                lockToolStripMenuItem.Text = "Unlock";
                board.Opacity = 0;
            }
            lockstate = !lockstate;
        }





        private void updateColor(string c)
        {
            switch (c)
            {
                case "Red":
                    labelPromptString.ForeColor = Color.Red;
                    break;
                case "Blue":
                    labelPromptString.ForeColor = Color.DeepSkyBlue;
                    break;
                case "Black":
                    labelPromptString.ForeColor = Color.Black;
                    break;
                case "White":
                    labelPromptString.ForeColor = Color.White;
                    break;
                case "Yellow":
                    labelPromptString.ForeColor = Color.Yellow;
                    break;
                case "Green":
                    labelPromptString.ForeColor = Color.Lime;
                    break;

                default:
                    break;
            }
        }

       /* private void labelPromptString_MouseDown(object sender, MouseEventArgs e)
        {
            startPoint = new Point(-e.X + SystemInformation.FrameBorderSize.Width, -e.Y - SystemInformation.FrameBorderSize.Height);
        }

        private void labelPromptString_MouseMove(object sender, MouseEventArgs e)
        {
            if (lockstate)
            {
                return;
            }



            if (e.Button == MouseButtons.Left)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(startPoint.X, startPoint.Y);
                labelPromptString.Location = mousePos;
            }
        }*/

        private void 設定文字ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (f == null || f.IsDisposed)
            {
                f = new Form3();
                f.Show(this);
            }
            else
            {
                f.Activate();
                f.WindowState = FormWindowState.Normal;
            }
        }

        private void labelPromptString_FontChanged(object sender, EventArgs e)
        {
            getFont();
        }

        private void 標楷體ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            labelPromptString.Font = new Font("標楷體", fontSize, fontStyle);
        }



        private void 新細明體ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            labelPromptString.Font = new Font("新細明體", fontSize, fontStyle);
        }

        private void calibriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            labelPromptString.Font = new Font("Calibri", fontSize, fontStyle);
        }

        private void timesNewRomanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            labelPromptString.Font = new Font("Times New Roman", fontSize, fontStyle);
        }

        private void 一般ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            labelPromptString.Font = new Font(fontFamily, fontSize, FontStyle.Regular);
        }

        private void 粗體ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            labelPromptString.Font = new Font(fontFamily, fontSize, FontStyle.Bold);
        }

        private void 斜體ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            labelPromptString.Font = new Font(fontFamily, fontSize, FontStyle.Italic);
        }

        private void 粗斜體ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            labelPromptString.Font = new Font(fontFamily, fontSize, FontStyle.Bold | FontStyle.Italic);
        }

        private void labelPromptString_FontChanged_1(object sender, EventArgs e)
        {
            getFont();
        }

        private void toolStripTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                fontSize = (float)int.Parse(toolStripTextBox1.Text);
                if (fontSize > 100 || fontSize < 8)
                {
                    toolStripTextBox1.Text = "";
                }
                else
                {
                    labelPromptString.Font = new Font(fontFamily, fontSize, fontStyle);
                    this.Activate();
                }
            }
            else
            {
                if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
                {

                }
                else
                {
                    e.Handled = true;
                }
            }
        }

        private void toolStripTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (toolStripTextBox1.Text == "")
            {
                return;
            }

            fontSize = (float)int.Parse(toolStripTextBox1.Text);
            if (fontSize > 100 || fontSize < 8)
            {
                ;
            }
            else
            {
                labelPromptString.Font = new Font(fontFamily, fontSize, fontStyle);
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            getFont();
            toolStripTextBox1.Text = fontSize.ToString();
        }

        private void toolStripTextBox2_TextChanged(object sender, EventArgs e)
        {
            labelPromptString.Font = new Font(toolStripTextBox2.Text, fontSize, fontStyle);
            getFont();
        }

        private void toolStripTextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                labelPromptString.Font = new Font(toolStripTextBox2.Text, fontSize, fontStyle);
                getFont();
                toolStripTextBox2.Text = fontFamily.Name;
                this.Activate();
            }

        }



        public string getMessage()
        {
            return labelPromptString.Text;
        }

        private void bulletinBoardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (timerMode)
            {
                labelPromptString.Text = tmpMsg;
                timer1.Enabled = false;
                timerMode = false;
            }
        }

        private void timerModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!timerMode)
            {
                tmpMsg = labelPromptString.Text;
                labelPromptString.Text = "Time: " + DateTime.Now.ToString("HH:mm:ss");
                timer1.Enabled = true;
                timerMode = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelPromptString.Text = "Time: " + DateTime.Now.ToString("HH:mm:ss");
        }


        public void changeToBoard()
        {
            if (timerMode)
            {
                timer1.Enabled = false;
                timerMode = false;
            }
        }

        private void labelPromptString_TextChanged(object sender, EventArgs e)
        {
            GC.Collect();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            board = new Form2(this);
            board.Show();
            board.Width = this.Width;
            board.Height = this.Height;
            board.Location = this.Location;
            string[] cmdString = Environment.GetCommandLineArgs();
            if (cmdString.Length == 2)
            {
                labelPromptString.Text = cmdString[1];
            }

            getFont();
            toolStripTextBox1.Text = fontSize.ToString();
            f = new Form3();
            f.Show(this);
            notifyIcon1.ShowBalloonTip(1000, "The bullentin board is running", "You can set the messenge or change the text style on the tray.", ToolTipIcon.Info);
            SetPenetrate();
        }


        public void setLocation(Point p)
        {
            this.Location = p;
        }

        public bool getLockState()
        {
            return lockstate;
        }

        public void SetPenetrate()
        {

            GetWindowLong(this.Handle, GWL_EXSTYLE);

            SetWindowLong(this.Handle, GWL_EXSTYLE, WS_EX_TRANSPARENT | WS_EX_LAYERED);

        }

        public void changeSize(int width, int height)
        {
            this.Width = width;
            this.Height = height;
        }

        public ContextMenuStrip getContextMenuStrip()
        {
            return this.contextMenuStrip1;
        }


    }



 
}
