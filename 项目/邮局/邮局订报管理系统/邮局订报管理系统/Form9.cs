using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Diagnostics;
namespace 邮局订报管理系统
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 用户登录 = new Form3();
            用户登录.Show(); 
        }

        private void button1_Click(object sender, EventArgs e)//查询
        {
            this.Hide();
            Form10 用户查询 = new Form10();
            用户查询.Show(); 
        }

        private void button2_Click(object sender, EventArgs e)//订报
        {
            this.Hide();
            Form11 用户订阅 = new Form11();
            用户订阅.Show(); 
        }
        private void Form9_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“邮局订报DataSet6.报刊”中。您可以根据需要移动或删除它。
            this.报刊TableAdapter.Fill(this.邮局订报DataSet6.报刊);
            this.BackgroundImage = Image.FromFile(@"F:\邮局\8.jpg");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
