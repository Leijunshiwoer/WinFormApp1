using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WinFormsApp1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private string _id;// 账号
        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _name;
        public string Name1 // 姓名
        {
            get { return _name; }
            set { _name = value; }
        }

        // 权限标记 值为admin为管理员 ，值为user则为普通用户
        private string _tag;
        public string _Tag
        {
            get { return _tag; }
            set { _tag = value; }
        }
       private void MainForm_Load(object sender, EventArgs e)
        {
            if (_Tag=="user")
            {
                toolStripStatusLabel2.Text = "权限管理：普通用户";
                toolStripStatusLabel3.Text = "" + Name1;
                新用户注册ToolStripMenuItem.Enabled = false;
                修改密码ToolStripMenuItem.Enabled = false;
                增加书籍ToolStripMenuItem.Enabled = false;
                修改书籍ToolStripMenuItem.Enabled = false;
                删除书籍ToolStripMenuItem.Enabled = false;

            }
            else
            {
                toolStripStatusLabel2.Text = "权限管理：管理员";
                toolStripStatusLabel3.Text = "" + Name1;
            }

        }
        public void Register()
        {
            ManyForms.RegisterForm rf = new();
            rf.Id = Id;
            rf.ShowDialog();

        }

        private void 新用户注册ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Register();
        }

        private void 切换账户ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 修改密码ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 查询书籍ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 增加书籍ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 修改书籍ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 删除书籍ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 借书ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 还书ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("是否退出?", "提示:", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (dr == DialogResult.OK)   //如果单击“是”按钮
            {
                e.Cancel = false;
                Application.Exit();
                                                 //关闭窗体
            }
            else if (dr == DialogResult.Cancel)
            {
                e.Cancel = true;                  //不执行操作
            }
        }
    }
}
