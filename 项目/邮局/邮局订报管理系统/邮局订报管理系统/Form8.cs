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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }
        string strcon = @"Data Source=localhost;database=邮局订报;uid=sa;pwd=123456";
        private SqlConnection conn; 
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 用户登录 = new Form3();
            用户登录.Show(); 
        }
        private void sqlConnect()
        {
            conn = new SqlConnection(strcon); conn.Open();
        }
        private void sqlClose()
        {
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             if (textBox1.Text != "" && (textBox2.Text) != "" &&  (textBox3.Text) != "" && (textBox4.Text) != "" && (textBox5.Text) != "")        
             {         
                 sqlConnect();
                 string sql = "insert into 用户 values ('" + textBox1.Text + "','" + textBox2.Text +"','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "')";    
                 SqlCommand cmd = new SqlCommand(sql, conn);        
                 cmd.ExecuteNonQuery();                                 
                 MessageBox.Show("      恭喜您！注册成功！！");
                 this.Hide();
                 Form3 用户登录 = new Form3();
                 用户登录.Show();                 
             }          
             else        
             {            
                 MessageBox.Show("您输入的内容可能为空！请检查重新输入！", ">>>>>>>警告<<<<<<<<");      
                 string str = "";        
                 textBox1.Text = str;    
                 textBox2.Text = str;       
                 textBox3.Text = str;       
                 textBox4.Text = str;        
                 textBox5.Text = str;            
                 return;           
             }                  
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile(@"F:\邮局\7.jpg");
        }
    }
}
