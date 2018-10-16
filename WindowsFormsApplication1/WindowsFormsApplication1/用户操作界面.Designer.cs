namespace WindowsFormsApplication1
{
    partial class 用户操作界面
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(用户操作界面));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.购买图书ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查询订单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改个人信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.书籍信息表BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.书店销售系统第六组DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.书店销售系统第六组DataSet = new WindowsFormsApplication1.书店销售系统第六组DataSet();
            this.书籍信息表TableAdapter = new WindowsFormsApplication1.书店销售系统第六组DataSetTableAdapters.书籍信息表TableAdapter();
            this.图书分类表BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.图书分类表TableAdapter = new WindowsFormsApplication1.书店销售系统第六组DataSetTableAdapters.图书分类表TableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.类别编号DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.类别名DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.SearchTJ = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.书籍信息表BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.书店销售系统第六组DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.书店销售系统第六组DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.图书分类表BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.购买图书ToolStripMenuItem,
            this.查询订单ToolStripMenuItem,
            this.修改个人信息ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1046, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 购买图书ToolStripMenuItem
            // 
            this.购买图书ToolStripMenuItem.Name = "购买图书ToolStripMenuItem";
            this.购买图书ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.购买图书ToolStripMenuItem.Text = "购买图书";
            this.购买图书ToolStripMenuItem.Click += new System.EventHandler(this.购买图书ToolStripMenuItem_Click);
            // 
            // 查询订单ToolStripMenuItem
            // 
            this.查询订单ToolStripMenuItem.Name = "查询订单ToolStripMenuItem";
            this.查询订单ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.查询订单ToolStripMenuItem.Text = "查询订单";
            this.查询订单ToolStripMenuItem.Click += new System.EventHandler(this.查询订单ToolStripMenuItem_Click);
            // 
            // 修改个人信息ToolStripMenuItem
            // 
            this.修改个人信息ToolStripMenuItem.Name = "修改个人信息ToolStripMenuItem";
            this.修改个人信息ToolStripMenuItem.Size = new System.Drawing.Size(92, 21);
            this.修改个人信息ToolStripMenuItem.Text = "修改个人信息";
            this.修改个人信息ToolStripMenuItem.Click += new System.EventHandler(this.修改个人信息ToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(745, 381);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // 书籍信息表BindingSource
            // 
            this.书籍信息表BindingSource.DataMember = "书籍信息表";
            this.书籍信息表BindingSource.DataSource = this.书店销售系统第六组DataSetBindingSource;
            // 
            // 书店销售系统第六组DataSetBindingSource
            // 
            this.书店销售系统第六组DataSetBindingSource.DataSource = this.书店销售系统第六组DataSet;
            this.书店销售系统第六组DataSetBindingSource.Position = 0;
            // 
            // 书店销售系统第六组DataSet
            // 
            this.书店销售系统第六组DataSet.DataSetName = "书店销售系统第六组DataSet";
            this.书店销售系统第六组DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // 书籍信息表TableAdapter
            // 
            this.书籍信息表TableAdapter.ClearBeforeFill = true;
            // 
            // 图书分类表BindingSource
            // 
            this.图书分类表BindingSource.DataMember = "图书分类表";
            this.图书分类表BindingSource.DataSource = this.书店销售系统第六组DataSetBindingSource;
            // 
            // 图书分类表TableAdapter
            // 
            this.图书分类表TableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.类别编号DataGridViewTextBoxColumn,
            this.类别名DataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.图书分类表BindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(788, 28);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.Size = new System.Drawing.Size(246, 381);
            this.dataGridView2.TabIndex = 2;
            // 
            // 类别编号DataGridViewTextBoxColumn
            // 
            this.类别编号DataGridViewTextBoxColumn.DataPropertyName = "类别编号";
            this.类别编号DataGridViewTextBoxColumn.HeaderText = "类别编号";
            this.类别编号DataGridViewTextBoxColumn.Name = "类别编号DataGridViewTextBoxColumn";
            // 
            // 类别名DataGridViewTextBoxColumn
            // 
            this.类别名DataGridViewTextBoxColumn.DataPropertyName = "类别名";
            this.类别名DataGridViewTextBoxColumn.HeaderText = "类别名";
            this.类别名DataGridViewTextBoxColumn.Name = "类别名DataGridViewTextBoxColumn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 432);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "查询图书：";
            // 
            // SearchTJ
            // 
            this.SearchTJ.Location = new System.Drawing.Point(80, 427);
            this.SearchTJ.Name = "SearchTJ";
            this.SearchTJ.Size = new System.Drawing.Size(126, 21);
            this.SearchTJ.TabIndex = 7;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(212, 424);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(65, 12);
            this.linkLabel1.TabIndex = 8;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "按书号查询";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(212, 441);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(65, 12);
            this.linkLabel2.TabIndex = 9;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "按书类查询";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(666, 421);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "刷新图书列表";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // 用户操作界面
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 515);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.SearchTJ);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "用户操作界面";
            this.Text = "用户操作界面";
            this.Load += new System.EventHandler(this.用户操作界面_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.书籍信息表BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.书店销售系统第六组DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.书店销售系统第六组DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.图书分类表BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 购买图书ToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource 书店销售系统第六组DataSetBindingSource;
        private 书店销售系统第六组DataSet 书店销售系统第六组DataSet;
        private System.Windows.Forms.BindingSource 书籍信息表BindingSource;
        private 书店销售系统第六组DataSetTableAdapters.书籍信息表TableAdapter 书籍信息表TableAdapter;
        private System.Windows.Forms.BindingSource 图书分类表BindingSource;
        private 书店销售系统第六组DataSetTableAdapters.图书分类表TableAdapter 图书分类表TableAdapter;
        private System.Windows.Forms.ToolStripMenuItem 查询订单ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.ToolStripMenuItem 修改个人信息ToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SearchTJ;
        private System.Windows.Forms.DataGridViewTextBoxColumn 类别编号DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 类别名DataGridViewTextBoxColumn;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Button button1;
    }
}