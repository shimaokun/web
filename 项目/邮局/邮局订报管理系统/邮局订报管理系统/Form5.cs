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
    public partial class Form5 : Form
    {
        string strcon = @"Data Source=localhost;database=邮局订报;uid=sa;pwd=123456";
        private SqlConnection conn; 
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sqlConnect(); 
            string sql = "insert into 报刊 values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "')"; 
            SqlCommand cmd = new SqlCommand(sql, conn); 
            cmd.ExecuteNonQuery(); 
            MessageBox.Show("      添加成功！！");
            this.Hide();
            Form5 管理添加 = new Form5();
            管理添加.Show();
        }
        private void sqlConnect()
        {
            conn = new SqlConnection(strcon); 
            conn.Open();
        }
        private void sqlClose()
        {
            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 管理目录 = new Form4();
            管理目录.Show(); 
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile(@"F:\邮局\6.jpg");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
