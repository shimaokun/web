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
    public partial class Form7 : Form
    {
        string strcon = @"Data Source=localhost;database=邮局订报;uid=sa;pwd=123456";
        private SqlConnection conn; 
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“邮局订报DataSet11.管理客户”中。您可以根据需要移动或删除它。
            this.管理客户TableAdapter1.Fill(this.邮局订报DataSet11.管理客户);
            // TODO: 这行代码将数据加载到表“邮局订报DataSet8.订阅”中。您可以根据需要移动或删除它。
            this.订阅TableAdapter2.Fill(this.邮局订报DataSet8.订阅);
            this.BackgroundImage = Image.FromFile(@"F:\邮局\11.jpg");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 管理目录 = new Form4();
            管理目录.Show(); 
        }
        private void sqlConnect()
        {
            conn = new SqlConnection(strcon); conn.Open();
        }
        private void sqlClose()
        {
            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sqlConnect();
            string sql = "insert into 管理客户 values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + comboBox1.Text + "')";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("添加成功！！");
            this.Hide();
            Form7 管理查询 = new Form7();
            管理查询.Show();
        }
    }
}
