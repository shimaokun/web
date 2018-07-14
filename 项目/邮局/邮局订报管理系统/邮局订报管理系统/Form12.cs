using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 邮局订报管理系统
{
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form9 用户功能 = new Form9();
            用户功能.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("在完成支付的一个工作日内,我们会将您所订阅的报刊发出！！");
            this.Hide();
            Form9 用户功能 = new Form9();
            用户功能.Show();
        }
    }
}
