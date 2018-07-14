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
    public partial class Form6 : Form
    {
        SqlDataAdapter adapter;
        DataSet dataset;
        string strcon = @"Data Source=localhost;database=邮局订报;uid=sa;pwd=123456";
        private SqlConnection conn; 
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile(@"F:\邮局\4.jpg");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = "Data Source=(local);Integrated Security=SSPI;database=邮局订报";
            sqlConnect();
                conn = new SqlConnection(str);
                conn.Open();
                string sqlstr = "select * from 报刊 ";
                adapter = new SqlDataAdapter(sqlstr, conn);
                dataset = new DataSet();
                adapter.Fill(dataset);
                if (dataset.Tables[0].Rows.Count >= 1)
                    dataGridView1.DataSource = dataset.Tables[0];
                conn.Close();
                conn.Dispose();
                dataset.Dispose();
            
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string str = "Data Source=(local);Integrated Security=SSPI;database=邮局订报"; 
            sqlConnect();
            string sql = "delete from 报刊 where 报刊名称 = '" + textBox1.Text + "'";    
            SqlCommand cmd = new SqlCommand(sql, conn);       
            cmd.ExecuteNonQuery();
                MessageBox.Show("删除成功！！", "提示！！！！");
                conn = new SqlConnection(str);
                conn.Open();
                string sqlstr = "select * from 报刊";
                adapter = new SqlDataAdapter(sqlstr, conn);
                dataset = new DataSet();
                adapter.Fill(dataset);
                if (dataset.Tables[0].Rows.Count >= 1)
                    dataGridView1.DataSource = dataset.Tables[0];
                conn.Close();
                conn.Dispose();
                dataset.Dispose();
        }
        private void sqlConnect()
        {
            conn = new SqlConnection(strcon); conn.Open();
        }
        private void sqlClose()
        {
            conn.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 管理目录 = new Form4();
            管理目录.Show(); 
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
