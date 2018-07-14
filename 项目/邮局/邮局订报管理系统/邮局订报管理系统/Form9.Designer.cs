namespace 邮局订报管理系统
{
    partial class Form9
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
            this.邮局订报DataSet6 = new 邮局订报管理系统.邮局订报DataSet6();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.报刊TableAdapter = new 邮局订报管理系统.邮局订报DataSet6TableAdapters.报刊TableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.报刊BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.邮局订报DataSet6)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(3, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(663, 438);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "报刊浏览";
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
            this.dataGridView1.Location = new System.Drawing.Point(6, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(643, 401);
            this.dataGridView1.TabIndex = 0;
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
            this.报刊BindingSource.DataSource = this.邮局订报DataSet6;
            // 
            // 邮局订报DataSet6
            // 
            this.邮局订报DataSet6.DataSetName = "邮局订报DataSet6";
            this.邮局订报DataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(672, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 30);
            this.button1.TabIndex = 1;
            this.button1.Text = "查询修改";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.Location = new System.Drawing.Point(672, 156);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 30);
            this.button2.TabIndex = 2;
            this.button2.Text = "订阅报刊";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button3.Location = new System.Drawing.Point(672, 287);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 30);
            this.button3.TabIndex = 3;
            this.button3.Text = "返回";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button4.Location = new System.Drawing.Point(672, 404);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 30);
            this.button4.TabIndex = 1;
            this.button4.Text = "退出";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // 报刊TableAdapter
            // 
            this.报刊TableAdapter.ClearBeforeFill = true;
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 462);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form9";
            this.Text = "用户功能";
            this.Load += new System.EventHandler(this.Form9_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.报刊BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.邮局订报DataSet6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private 邮局订报DataSet6 邮局订报DataSet6;
        private System.Windows.Forms.BindingSource 报刊BindingSource;
        private 邮局订报DataSet6TableAdapters.报刊TableAdapter 报刊TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn 报刊编号DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 报刊名称DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 报刊单价DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 报刊类型DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 报刊出版社DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 报刊版面规格DataGridViewTextBoxColumn;
    }
}