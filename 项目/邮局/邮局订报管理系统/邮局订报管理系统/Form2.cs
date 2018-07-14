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
    public partial class Form2 : Form
    {
        string strcon = @"Data Source=localhost;database=邮局订报;uid=sa;pwd=123456";
        private SqlConnection conn; 
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile(@"F:\邮局\1.jpg");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            sqlConnect();
            string sql = "select 管理员密码 from 管理员 where 管理员账号 = '" + textBox1.Text + "'"; 
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
                    MessageBox.Show("欢迎管理员" + textBox1.Text + "登录系统！");  
                    this.Hide();    
                    Form4 管理目录 = new Form4();      
                    管理目录.Show();          
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
            conn = new SqlConnection(strcon);    
            conn.Open();       
        }          
        private void sqlClose()    
        {            
            conn.Close();     
        }
        private void 忘记密码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("请联系开发者：6034896798@qq.com");
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 返回ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 邮局订报管理系统 = new Form1();
            邮局订报管理系统.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
