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
    public partial class Form10 : Form
    {
        SqlDataAdapter adapter;
        DataSet dataset;
        string strcon = @"Data Source=localhost;database=邮局订报;uid=sa;pwd=123456";
        private SqlConnection conn;
        public Form10()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form9 用户功能 = new Form9();
            用户功能.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String str = "Data Source=(local);Integrated Security=SSPI;database=邮局订报";
            sqlConnect();
            string sql = "select 用户姓名 as 用户姓名,报刊名称 as 报刊名称,数量 as 数量,地址 as 地址,邮编 as 邮编 from 订阅 where 用户姓名 = '" + textBox1.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            if (cmd.ExecuteScalar() == null)
            {
                MessageBox.Show("该用户暂无订阅信息！！", "    提示信息");
                return;
            }
            else
            {
                conn = new SqlConnection(str);
                conn.Open();
                adapter = new SqlDataAdapter(sql, conn);
                dataset = new DataSet();
                adapter.Fill(dataset);
                if (dataset.Tables[0].Rows.Count >= 1)
                    dataGridView1.DataSource = dataset.Tables[0];
                conn.Close();
                conn.Dispose();
                dataset.Dispose();
            }
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

        private void Form10_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile(@"F:\邮局\9.jpg");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "" && (textBox3.Text) != "" && (textBox4.Text) != "" && (textBox5.Text) != "" && (textBox6.Text) != "")
            {
                sqlConnect();
                string sql = "Update 用户 set 用户姓名='" + textBox2.Text + "',用户密码='" + textBox3.Text + "',电话='" + textBox4.Text + "',邮编='" + textBox5.Text + "',地址='" + textBox6.Text + "' where 用户密码=" + textBox1.Text;
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("      恭喜您！修改成功！！");
                this.Hide();
                Form9 用户查询 = new Form9();
                用户查询.Show();
            }
            else
            {
                MessageBox.Show("您输入的内容可能为空！请检查重新输入！", ">>>>>>>警告<<<<<<<<");
                string str = "";
                textBox2.Text = str;
                textBox3.Text = str;
                textBox4.Text = str;
                textBox5.Text = str;
                textBox6.Text = str;
                return;
            }
        }
    }
}
