using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kt8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string userName = textboxusername.Text;
            string passWord = textboxmatkhau.Text;
            if (userName == "admin" && passWord == "admin")
            {
                MessageBox.Show("đăng nhập thành công!!!");
            }
        }
    }
}
