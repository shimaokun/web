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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“邮局订报DataSet5.报刊”中。您可以根据需要移动或删除它。
            this.报刊TableAdapter.Fill(this.邮局订报DataSet5.报刊);
            this.BackgroundImage = Image.FromFile(@"F:\邮局\3.jpg");
        }
        private void 添加报刊ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 管理添加 = new Form5();
            管理添加.Show();
        }

        private void 删除报刊ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 管理删除 = new Form6();
            管理删除.Show();
        }

        private void 订阅查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form7 管理查询 = new Form7();
            管理查询.Show();
        }

        private void 返回ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 邮局订报系统 = new Form1();
            邮局订报系统.Show();
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
