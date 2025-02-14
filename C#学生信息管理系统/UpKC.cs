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
{

    public partial class UpKC : Form
    {
        static string conflg = "database=pxscj;" +
                       "datasource = 127.0.0.1;" +
                       "userid = root;" +
                       "port=3306;" +
                       "password=55555"; //数据库连接字段
        MySqlConnection conn = new MySqlConnection(conflg);
        static string id = ""; //保存课程数
       
        public UpKC()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            try
            { conn.Open(); }
            catch
            {
                MessageBox.Show("数据库连接失败!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
        }

        // 添加课程
        private void button_yes_Click(object sender, EventArgs e)
        {
            if (textBox_kc.Text == "")
            {
                MessageBox.Show("请输入课程名", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                try
                {
                    string kc_name = textBox_kc.Text.ToString();
                    string str = "INSERT INTO KC VALUES('" + id + "',  '" + kc_name + "',NULL);";// 插入语句
                    MySqlCommand kcmd = new MySqlCommand(str, conn);
                    kcmd.ExecuteNonQuery();
                    MessageBox.Show("添加成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    NEW(null, null);
                }
                catch
                {
                    MessageBox.Show("添加失败!已有该课程", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            return;
        }
        //删除课程
        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox_kc.Text == "")
            {
                MessageBox.Show("请输入课程名", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                try
                {
                    string kc_name = textBox_kc.Text;
                    string str = "DELETE FROM KC WHERE KCM='" + kc_name + "';";
                    MySqlCommand cmd = new MySqlCommand(str, conn);
                    MessageBox.Show("删除成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    cmd.ExecuteNonQuery();
                    NEW(null, null);
                }
                catch
                {
                    MessageBox.Show("删除失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            return;
        }
        //加载所有课程
        private void UpKC_Load(object sender, EventArgs e)
        {
            NEW(null, null);
            return;
        }
        private void NEW(object sender,EventArgs e)
        {
            string kcm = "SELECT  KCM AS 课程名 FROM KC ";
            MySqlDataAdapter da = new MySqlDataAdapter(kcm, conn);// 打开数据适配器（用于读取数据）
            DataSet ds = new DataSet();//创建数据表
            da.Fill(ds);
            dataGridView_kc.DataSource = ds.Tables[0];// 把dataset 与dataGridView_xmcj数据绑定一起
            id= dataGridView_kc.Rows.Count.ToString();//获取总课程数
            textBox_kc.Text = "";
            return;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Close();
            this.Hide();
            return;
        }
    }
}
