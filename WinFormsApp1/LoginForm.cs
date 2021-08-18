using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WinFormsApp1
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = textBox1.Text.Trim();
            string pwd = textBox2.Text.Trim();
            if (id == "" || pwd == "")
            {
                MessageBox.Show("请输入用户名和密码");
            }
            else
            {
                string str = System.Configuration.ConfigurationManager.ConnectionStrings["library"].ConnectionString;
                string sql;
                if (radioButton1.Checked==true)
                {
                   sql= "select uName from users where uId='" + id + "' and uPwd='" + pwd + "'";
                }
                else
                {
                        sql="select aName from admin where aId='" + id + "' and aPwd='" + pwd + "'";
                }
                using (SqlConnection conn = new SqlConnection(str))
                {
                    SqlCommand cmd = new SqlCommand(sql,conn);
                    conn.Open();
                    if (cmd.ExecuteScalar() == null)
                    {
                        MessageBox.Show("该账号不存在");
                    }
                    else
                    {
                        string name = cmd.ExecuteScalar().ToString();
                        if (name != "")
                        {
                            // 登录窗体隐藏
                            this.Hide();
                            // 创建主窗体
                            MainForm mainForm = new MainForm();
                            // 将账号传给主窗体MainForm
                            mainForm.Id = id;
                            // 用主窗体MainForm下的_Tag标记登陆的是用户还是管理员
                            if (radioButton1.Checked == true)
                            {
                                mainForm._Tag = "user";
                                mainForm.Name1 = name;
                               
                                


                            }
                            else
                            {
                                mainForm._Tag = "admin";
                                mainForm.Name1 = name;
                               
                            }
                            //显示主窗体
                            MessageBox.Show("登录成功！");
                            mainForm.ShowDialog();
                           
                        }
                        else
                        {
                            MessageBox.Show("账号或密码错误！", "登录失败");
                        }
                    }
                }
            }
        }
    }
}
