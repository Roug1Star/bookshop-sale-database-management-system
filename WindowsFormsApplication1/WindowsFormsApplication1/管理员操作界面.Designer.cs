namespace WindowsFormsApplication1
{
    partial class 管理员操作界面
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(管理员操作界面));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.权限管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.图书入库ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.图书分类ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.图书销售情况ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.书店销售系统第六组DataSet1 = new WindowsFormsApplication1.书店销售系统第六组DataSet1();
            this.图书入库信息登记表BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.图书入库信息登记表TableAdapter = new WindowsFormsApplication1.书店销售系统第六组DataSet1TableAdapters.图书入库信息登记表TableAdapter();
            this.update = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.Insert = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.类别编号DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.类别名DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.图书分类表BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.书店销售系统第六组DataSet = new WindowsFormsApplication1.书店销售系统第六组DataSet();
            this.图书分类表TableAdapter = new WindowsFormsApplication1.书店销售系统第六组DataSetTableAdapters.图书分类表TableAdapter();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.书店销售系统第六组DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.图书入库信息登记表BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.图书分类表BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.书店销售系统第六组DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.权限管理ToolStripMenuItem,
            this.图书入库ToolStripMenuItem,
            this.图书分类ToolStripMenuItem,
            this.图书销售情况ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(857, 25);
            this.menuStrip1.TabIndex = 0;
            // 
            // 权限管理ToolStripMenuItem
            // 
            this.权限管理ToolStripMenuItem.Name = "权限管理ToolStripMenuItem";
            this.权限管理ToolStripMenuItem.Size = new System.Drawing.Size(80, 21);
            this.权限管理ToolStripMenuItem.Text = "管理员信息";
            this.权限管理ToolStripMenuItem.Click += new System.EventHandler(this.权限管理ToolStripMenuItem_Click);
            // 
            // 图书入库ToolStripMenuItem
            // 
            this.图书入库ToolStripMenuItem.Name = "图书入库ToolStripMenuItem";
            this.图书入库ToolStripMenuItem.Size = new System.Drawing.Size(104, 21);
            this.图书入库ToolStripMenuItem.Text = "图书信息与入库";
            this.图书入库ToolStripMenuItem.Click += new System.EventHandler(this.图书入库ToolStripMenuItem_Click);
            // 
            // 图书分类ToolStripMenuItem
            // 
            this.图书分类ToolStripMenuItem.Name = "图书分类ToolStripMenuItem";
            this.图书分类ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.图书分类ToolStripMenuItem.Text = "图书分类";
            this.图书分类ToolStripMenuItem.Click += new System.EventHandler(this.图书分类ToolStripMenuItem_Click);
            // 
            // 图书销售情况ToolStripMenuItem
            // 
            this.图书销售情况ToolStripMenuItem.Name = "图书销售情况ToolStripMenuItem";
            this.图书销售情况ToolStripMenuItem.Size = new System.Drawing.Size(92, 21);
            this.图书销售情况ToolStripMenuItem.Text = "图书销售情况";
            this.图书销售情况ToolStripMenuItem.Click += new System.EventHandler(this.图书销售情况ToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(833, 220);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // 书店销售系统第六组DataSet1
            // 
            this.书店销售系统第六组DataSet1.DataSetName = "书店销售系统第六组DataSet1";
            this.书店销售系统第六组DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // 图书入库信息登记表BindingSource
            // 
            this.图书入库信息登记表BindingSource.DataMember = "图书入库信息登记表";
            this.图书入库信息登记表BindingSource.DataSource = this.书店销售系统第六组DataSet1;
            // 
            // 图书入库信息登记表TableAdapter
            // 
            this.图书入库信息登记表TableAdapter.ClearBeforeFill = true;
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(428, 312);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(75, 23);
            this.update.TabIndex = 2;
            this.update.Text = "修改";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(428, 349);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 23);
            this.delete.TabIndex = 3;
            this.delete.Text = "删除";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 277);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "入库编号：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 303);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "入库书号：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 328);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "入库书名：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(226, 277);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "入库书类：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(226, 303);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "入库出版社：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 354);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 12);
            this.label6.TabIndex = 9;
            this.label6.Text = "入库书作者：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(226, 328);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 10;
            this.label7.Text = "销售价格：";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(87, 274);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 11;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(87, 300);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 21);
            this.textBox2.TabIndex = 12;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(87, 325);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 21);
            this.textBox3.TabIndex = 13;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(87, 351);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 21);
            this.textBox4.TabIndex = 14;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(297, 274);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 21);
            this.textBox5.TabIndex = 15;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(298, 300);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 21);
            this.textBox6.TabIndex = 16;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(298, 327);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 21);
            this.textBox7.TabIndex = 17;
            // 
            // Insert
            // 
            this.Insert.Location = new System.Drawing.Point(428, 275);
            this.Insert.Name = "Insert";
            this.Insert.Size = new System.Drawing.Size(75, 23);
            this.Insert.TabIndex = 18;
            this.Insert.Text = "插入";
            this.Insert.UseVisualStyleBackColor = true;
            this.Insert.Click += new System.EventHandler(this.Insert_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(518, 274);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 98);
            this.button1.TabIndex = 19;
            this.button1.Text = "刷新";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.类别编号DataGridViewTextBoxColumn,
            this.类别名DataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.图书分类表BindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(623, 254);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.Size = new System.Drawing.Size(222, 130);
            this.dataGridView2.TabIndex = 20;
            // 
            // 类别编号DataGridViewTextBoxColumn
            // 
            this.类别编号DataGridViewTextBoxColumn.DataPropertyName = "类别编号";
            this.类别编号DataGridViewTextBoxColumn.HeaderText = "类别编号";
            this.类别编号DataGridViewTextBoxColumn.Name = "类别编号DataGridViewTextBoxColumn";
            this.类别编号DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 类别名DataGridViewTextBoxColumn
            // 
            this.类别名DataGridViewTextBoxColumn.DataPropertyName = "类别名";
            this.类别名DataGridViewTextBoxColumn.HeaderText = "类别名";
            this.类别名DataGridViewTextBoxColumn.Name = "类别名DataGridViewTextBoxColumn";
            this.类别名DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 图书分类表BindingSource
            // 
            this.图书分类表BindingSource.DataMember = "图书分类表";
            this.图书分类表BindingSource.DataSource = this.书店销售系统第六组DataSet;
            // 
            // 书店销售系统第六组DataSet
            // 
            this.书店销售系统第六组DataSet.DataSetName = "书店销售系统第六组DataSet";
            this.书店销售系统第六组DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // 图书分类表TableAdapter
            // 
            this.图书分类表TableAdapter.ClearBeforeFill = true;
            // 
            // 管理员操作界面
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 396);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Insert);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.update);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "管理员操作界面";
            this.Text = "管理员操作界面";
            this.Load += new System.EventHandler(this.管理员操作界面_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.书店销售系统第六组DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.图书入库信息登记表BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.图书分类表BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.书店销售系统第六组DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 权限管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 图书分类ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 图书销售情况ToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private 书店销售系统第六组DataSet1 书店销售系统第六组DataSet1;
        private System.Windows.Forms.BindingSource 图书入库信息登记表BindingSource;
        private 书店销售系统第六组DataSet1TableAdapters.图书入库信息登记表TableAdapter 图书入库信息登记表TableAdapter;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Button Insert;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem 图书入库ToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView2;
        private 书店销售系统第六组DataSet 书店销售系统第六组DataSet;
        private System.Windows.Forms.BindingSource 图书分类表BindingSource;
        private 书店销售系统第六组DataSetTableAdapters.图书分类表TableAdapter 图书分类表TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn 类别编号DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 类别名DataGridViewTextBoxColumn;
    }
}