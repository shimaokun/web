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
    public partial class Form3 : Form
    {
        string strcon = @"Data Source=localhost;database=邮局订报;uid=sa;pwd=123456";
        private SqlConnection conn; 
        public Form3()
        {
            InitializeComponent();
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile(@"F:\邮局\2.jpg");
        }
        private void button1_Click(object sender, EventArgs e)//登录
        {
            sqlConnect();  
            string sql = "select 用户密码 from 用户 where 用户姓名 = '" + textBox1.Text + "'"; 
            SqlCommand cmd = new SqlCommand(sql, conn);         
            if (cmd.ExecuteScalar() == null)        
            {               
                MessageBox.Show("账号输入错误");   
                return;           
            }            
            else        
            {        
                if (textBox2.Text == cmd.ExecuteScalar().ToString().Trim())   
                {
                    MessageBox.Show("欢迎用户" + textBox1.Text + "登录系统！"); 
                    this.Hide();
                    Form9 用户功能 = new Form9();    
                    用户功能.Show();        
                }
                else
                {
                    MessageBox.Show("密码输入错误");
                    return;
                }         
            }      
        }
        private void sqlConnect() 
        {
            conn = new SqlConnection(strcon); conn.Open(); 
        }                  
        private void sqlClose() 
        {
            conn.Close();
        }
        private void 注册ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form8 用户注册 = new Form8();
            用户注册.Show();
        }

        private void 返回ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 邮局订报管理系统 = new Form1();
            邮局订报管理系统.Show(); 
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 忘记密码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("请联系开发者：6034896798@qq.com");
        }
    }
}
