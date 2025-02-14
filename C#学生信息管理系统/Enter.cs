using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace pxscj
{/// <summary>
/// 登入界面
/// </summary>
    public partial class Enter : Form
    {
        static string config = "database=pxscj;" +
                        "datasource = 127.0.0.1;" +
                        "userid = root;" +
                        "port=3306;" +
                        "password=55555"; //数据库连接字段
        MySqlConnection conn = new MySqlConnection(config); //连接数据库
        public Enter()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //  登入按钮事件响应
        private void Enter_button_Click(object sender, EventArgs e)
        {
            try
            { conn.Open(); }
            catch
            {
                MessageBox.Show("数据库连接失败!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            if (name_textBox.Text== "")
            {
                MessageBox.Show("用户名不能为空", "用户登入", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
     
            }
            else if(paw_textBox.Text == "")
            {
                MessageBox.Show("密码不能为空", "用户登入", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                string user_Id = name_textBox.Text;
                string password = paw_textBox.Text;
                string sql = "SELECT COUNT(*) FROM USER_STU WHERE ID='" + user_Id + "'AND PASSWORD='" + password + "';";
                string sql1 = "SELECT COUNT(*) FROM USER_ADM WHERE ID='" + user_Id + "'AND PASSWORD='" + password + "';";
                MySqlCommand cmd = new MySqlCommand(sql, conn);//查询
                MySqlCommand cmd1 = new MySqlCommand(sql1, conn);//查询
                if (Convert.ToInt32(cmd.ExecuteScalar()) == 1 ) // 转换 查找 找到为1 
                {
                    //进入学生界面
                    MessageBox.Show("登入成功", "欢迎使用", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    Stu stu = new Stu(user_Id);
                    stu.Show();
                    this.Hide();
                }
                else if(Convert.ToInt32(cmd1.ExecuteScalar()) == 1)
                {
                    // 进入管理员界面
                    MessageBox.Show("登入成功", "欢迎使用", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    Adm adm = new Adm();
                    adm.Show();
                    this.Hide();

                }
                else //登入成功则直接进入信息界面
                {
                   MessageBox.Show("账号或者密码错误，请重新输入", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                conn.Close();
            }
            return;
        }
        
    }
}
