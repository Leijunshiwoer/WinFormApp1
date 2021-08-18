using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace WinFormsApp1.ManyForms
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

      

        private string _id;
        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }
        private void RegistForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            string uGender;
            if (radioButton1.Checked==true)
            {
                uGender = "男";
            }
            else
            {
                uGender = "女";
            }
            if (textBox1.Text.Trim().Length<6)
            {
                MessageBox.Show("账号的长度不小于6");
            }
            else if (textBox2.Text.Trim().Length<6)
            {
                MessageBox.Show("密码的长度不小于6");
            }
            else if (textBox3.Text.Trim().Length<2||textBox3.Text.Trim().Length>15)
            {
                MessageBox.Show("姓名的长度应小于15大于1");
            }
            else if (Regex.IsMatch(textBox4.Text.Trim(), @"86-\d{2,3}-\d{7,8}")!=true)
            {
                MessageBox.Show("请输入正确的手机号码");
            }
            else if (SqlHelper.IsUserExists( textBox1.Text.Trim()))
            {
                MessageBox.Show("账号已存在");
                return;
            }

        }

    
    }
}
