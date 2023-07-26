using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.MouseDown += new MouseEventHandler(this.Form_MouseDown);
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void Form_MouseDown(object sender, MouseEventArgs e)
        {
            MessageBox.Show("안녕하세요!");
        }
    }
}
