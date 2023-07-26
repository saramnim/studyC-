using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginForm1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Shown += form_shown;
        }
        private void form_shown(object sender, EventArgs e)
        {
            txtID.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "asdf" && txtPW.Text == "1234")
            {
                MessageBox.Show("로그인에 성공했습니다.");
            }
            else
            {
                MessageBox.Show("ID 또는 비밀번호가 틀립니다.");
            }
        }
    }
}
