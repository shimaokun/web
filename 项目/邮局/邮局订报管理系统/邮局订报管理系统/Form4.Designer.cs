namespace 邮局订报管理系统
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.报刊编号DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.报刊名称DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.报刊单价DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.报刊类型DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.报刊出版社DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.报刊版面规格DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.报刊BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.邮局订报DataSet5 = new 邮局订报管理系统.邮局订报DataSet5();
            this.报刊TableAdapter = new 邮局订报管理系统.邮局订报DataSet5TableAdapters.报刊TableAdapter();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.菜单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.添加报刊ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除报刊ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.订阅查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.返回ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.报刊BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.邮局订报DataSet5)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(12, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(749, 417);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "报刊信息";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.报刊编号DataGridViewTextBoxColumn,
            this.报刊名称DataGridViewTextBoxColumn,
            this.报刊单价DataGridViewTextBoxColumn,
            this.报刊类型DataGridViewTextBoxColumn,
            this.报刊出版社DataGridViewTextBoxColumn,
            this.报刊版面规格DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.报刊BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(24, 45);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(643, 386);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // 报刊编号DataGridViewTextBoxColumn
            // 
            this.报刊编号DataGridViewTextBoxColumn.DataPropertyName = "报刊编号";
            this.报刊编号DataGridViewTextBoxColumn.HeaderText = "报刊编号";
            this.报刊编号DataGridViewTextBoxColumn.Name = "报刊编号DataGridViewTextBoxColumn";
            // 
            // 报刊名称DataGridViewTextBoxColumn
            // 
            this.报刊名称DataGridViewTextBoxColumn.DataPropertyName = "报刊名称";
            this.报刊名称DataGridViewTextBoxColumn.HeaderText = "报刊名称";
            this.报刊名称DataGridViewTextBoxColumn.Name = "报刊名称DataGridViewTextBoxColumn";
            // 
            // 报刊单价DataGridViewTextBoxColumn
            // 
            this.报刊单价DataGridViewTextBoxColumn.DataPropertyName = "报刊单价";
            this.报刊单价DataGridViewTextBoxColumn.HeaderText = "报刊单价";
            this.报刊单价DataGridViewTextBoxColumn.Name = "报刊单价DataGridViewTextBoxColumn";
            // 
            // 报刊类型DataGridViewTextBoxColumn
            // 
            this.报刊类型DataGridViewTextBoxColumn.DataPropertyName = "报刊类型";
            this.报刊类型DataGridViewTextBoxColumn.HeaderText = "报刊类型";
            this.报刊类型DataGridViewTextBoxColumn.Name = "报刊类型DataGridViewTextBoxColumn";
            // 
            // 报刊出版社DataGridViewTextBoxColumn
            // 
            this.报刊出版社DataGridViewTextBoxColumn.DataPropertyName = "报刊出版社";
            this.报刊出版社DataGridViewTextBoxColumn.HeaderText = "报刊出版社";
            this.报刊出版社DataGridViewTextBoxColumn.Name = "报刊出版社DataGridViewTextBoxColumn";
            // 
            // 报刊版面规格DataGridViewTextBoxColumn
            // 
            this.报刊版面规格DataGridViewTextBoxColumn.DataPropertyName = "报刊版面规格";
            this.报刊版面规格DataGridViewTextBoxColumn.HeaderText = "报刊版面规格";
            this.报刊版面规格DataGridViewTextBoxColumn.Name = "报刊版面规格DataGridViewTextBoxColumn";
            // 
            // 报刊BindingSource
            // 
            this.报刊BindingSource.DataMember = "报刊";
            this.报刊BindingSource.DataSource = this.邮局订报DataSet5;
            // 
            // 邮局订报DataSet5
            // 
            this.邮局订报DataSet5.DataSetName = "邮局订报DataSet5";
            this.邮局订报DataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // 报刊TableAdapter
            // 
            this.报刊TableAdapter.ClearBeforeFill = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.菜单ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 菜单ToolStripMenuItem
            // 
            this.菜单ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.添加报刊ToolStripMenuItem,
            this.删除报刊ToolStripMenuItem,
            this.订阅查询ToolStripMenuItem,
            this.返回ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.菜单ToolStripMenuItem.Name = "菜单ToolStripMenuItem";
            this.菜单ToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.菜单ToolStripMenuItem.Text = "菜单";
            // 
            // 添加报刊ToolStripMenuItem
            // 
            this.添加报刊ToolStripMenuItem.Name = "添加报刊ToolStripMenuItem";
            this.添加报刊ToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.添加报刊ToolStripMenuItem.Text = "添加报刊";
            this.添加报刊ToolStripMenuItem.Click += new System.EventHandler(this.添加报刊ToolStripMenuItem_Click);
            // 
            // 删除报刊ToolStripMenuItem
            // 
            this.删除报刊ToolStripMenuItem.Name = "删除报刊ToolStripMenuItem";
            this.删除报刊ToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.删除报刊ToolStripMenuItem.Text = "删除报刊";
            this.删除报刊ToolStripMenuItem.Click += new System.EventHandler(this.删除报刊ToolStripMenuItem_Click);
            // 
            // 订阅查询ToolStripMenuItem
            // 
            this.订阅查询ToolStripMenuItem.Name = "订阅查询ToolStripMenuItem";
            this.订阅查询ToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.订阅查询ToolStripMenuItem.Text = "订阅查询";
            this.订阅查询ToolStripMenuItem.Click += new System.EventHandler(this.订阅查询ToolStripMenuItem_Click);
            // 
            // 返回ToolStripMenuItem
            // 
            this.返回ToolStripMenuItem.Name = "返回ToolStripMenuItem";
            this.返回ToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.返回ToolStripMenuItem.Text = "返回";
            this.返回ToolStripMenuItem.Click += new System.EventHandler(this.返回ToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 462);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form4";
            this.Text = "管理目录";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.报刊BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.邮局订报DataSet5)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private 邮局订报DataSet5 邮局订报DataSet5;
        private System.Windows.Forms.BindingSource 报刊BindingSource;
        private 邮局订报DataSet5TableAdapters.报刊TableAdapter 报刊TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn 报刊编号DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 报刊名称DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 报刊单价DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 报刊类型DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 报刊出版社DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 报刊版面规格DataGridViewTextBoxColumn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 菜单ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 添加报刊ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除报刊ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 订阅查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 返回ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
    }
}