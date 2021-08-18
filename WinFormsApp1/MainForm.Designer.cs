
namespace WinFormsApp1
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.新用户注册ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.切换账户ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改密码ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查询书籍ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.增加书籍ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改书籍ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除书籍ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.借书ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.还书ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox1,
            this.toolStripComboBox2,
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(665, 25);
            this.menuStrip1.TabIndex = 0;
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新用户注册ToolStripMenuItem,
            this.切换账户ToolStripMenuItem,
            this.修改密码ToolStripMenuItem});
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(68, 21);
            this.toolStripComboBox1.Text = "用户管理";
            // 
            // toolStripComboBox2
            // 
            this.toolStripComboBox2.Name = "toolStripComboBox2";
            this.toolStripComboBox2.Size = new System.Drawing.Size(12, 21);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.查询书籍ToolStripMenuItem,
            this.增加书籍ToolStripMenuItem,
            this.修改书籍ToolStripMenuItem,
            this.删除书籍ToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(68, 21);
            this.toolStripMenuItem1.Text = "图书管理";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.借书ToolStripMenuItem,
            this.还书ToolStripMenuItem});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(68, 21);
            this.toolStripMenuItem2.Text = "借还管理";
            // 
            // 新用户注册ToolStripMenuItem
            // 
            this.新用户注册ToolStripMenuItem.Name = "新用户注册ToolStripMenuItem";
            this.新用户注册ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.新用户注册ToolStripMenuItem.Text = "新用户注册";
            this.新用户注册ToolStripMenuItem.Click += new System.EventHandler(this.新用户注册ToolStripMenuItem_Click);
            // 
            // 切换账户ToolStripMenuItem
            // 
            this.切换账户ToolStripMenuItem.Name = "切换账户ToolStripMenuItem";
            this.切换账户ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.切换账户ToolStripMenuItem.Text = "切换账户";
            this.切换账户ToolStripMenuItem.Click += new System.EventHandler(this.切换账户ToolStripMenuItem_Click);
            // 
            // 修改密码ToolStripMenuItem
            // 
            this.修改密码ToolStripMenuItem.Name = "修改密码ToolStripMenuItem";
            this.修改密码ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.修改密码ToolStripMenuItem.Text = "修改密码";
            this.修改密码ToolStripMenuItem.Click += new System.EventHandler(this.修改密码ToolStripMenuItem_Click);
            // 
            // 查询书籍ToolStripMenuItem
            // 
            this.查询书籍ToolStripMenuItem.Name = "查询书籍ToolStripMenuItem";
            this.查询书籍ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.查询书籍ToolStripMenuItem.Text = "查询书籍";
            this.查询书籍ToolStripMenuItem.Click += new System.EventHandler(this.查询书籍ToolStripMenuItem_Click);
            // 
            // 增加书籍ToolStripMenuItem
            // 
            this.增加书籍ToolStripMenuItem.Name = "增加书籍ToolStripMenuItem";
            this.增加书籍ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.增加书籍ToolStripMenuItem.Text = "增加书籍";
            this.增加书籍ToolStripMenuItem.Click += new System.EventHandler(this.增加书籍ToolStripMenuItem_Click);
            // 
            // 修改书籍ToolStripMenuItem
            // 
            this.修改书籍ToolStripMenuItem.Name = "修改书籍ToolStripMenuItem";
            this.修改书籍ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.修改书籍ToolStripMenuItem.Text = "修改书籍";
            this.修改书籍ToolStripMenuItem.Click += new System.EventHandler(this.修改书籍ToolStripMenuItem_Click);
            // 
            // 删除书籍ToolStripMenuItem
            // 
            this.删除书籍ToolStripMenuItem.Name = "删除书籍ToolStripMenuItem";
            this.删除书籍ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.删除书籍ToolStripMenuItem.Text = "删除书籍";
            this.删除书籍ToolStripMenuItem.Click += new System.EventHandler(this.删除书籍ToolStripMenuItem_Click);
            // 
            // 借书ToolStripMenuItem
            // 
            this.借书ToolStripMenuItem.Name = "借书ToolStripMenuItem";
            this.借书ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.借书ToolStripMenuItem.Text = "借书";
            this.借书ToolStripMenuItem.Click += new System.EventHandler(this.借书ToolStripMenuItem_Click);
            // 
            // 还书ToolStripMenuItem
            // 
            this.还书ToolStripMenuItem.Name = "还书ToolStripMenuItem";
            this.还书ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.还书ToolStripMenuItem.Text = "还书";
            this.还书ToolStripMenuItem.Click += new System.EventHandler(this.还书ToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 417);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(665, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(128, 17);
            this.toolStripStatusLabel1.Text = "欢迎登录图书管理系统";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(116, 17);
            this.toolStripStatusLabel2.Text = "权限管理：普通用户";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(26, 17);
            this.toolStripStatusLabel3.Text = "xxx";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 439);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripComboBox1;
        private System.Windows.Forms.ToolStripMenuItem 新用户注册ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 切换账户ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改密码ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripComboBox2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 查询书籍ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 增加书籍ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改书籍ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除书籍ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem 借书ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 还书ToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
    }
}