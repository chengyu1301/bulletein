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
    public partial class Form3 : Form
    {
        public Form3()
        {
            
            InitializeComponent();

        }



        private void button1_Click(object sender, EventArgs e)
        {
            Form1 parentForm = (Form1)this.Owner;
            parentForm.changeToBoard();
            parentForm.setMessage(textBox1.Text);
            GC.Collect();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 parentForm = (Form1)this.Owner;
            parentForm.changeToBoard();
            parentForm.setMessage("");
            textBox1.Text = "";
            GC.Collect();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            Form1 parentForm = (Form1)this.Owner;
            textBox1.Text = parentForm.getMessage();
        }






    }
}
