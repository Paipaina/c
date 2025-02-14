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
    public partial class Choose : Form
    {
        static string conflg = "database=pxscj;" +
                       "datasource = 127.0.0.1;" +
                       "userid = root;" +
                       "port=3306;" +
                       "password=55555"; //数据库连接字段
        MySqlConnection conn = new MySqlConnection(conflg);
        static string sno = "";//接收学号文本框
        public Choose()
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
        //查看学生
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox_sno.Text != "")
            {
                string str = "SELECT * FROM XS WHERE ID ='" + textBox_sno.Text.ToString() + "';";
                MySqlCommand pcmd = new MySqlCommand(str, conn);
                MySqlDataReader dr = pcmd.ExecuteReader(); //用DataReader 读数据
                if (dr.Read()) //判断是否有该学生
                {
                    sno = textBox_sno.Text.ToString();
                    Stu stu = new Stu(sno);
                    stu.Show();
                }
                else
                {
                    MessageBox.Show("无此学生！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                dr.Close();
     
            }
            else
            {
                MessageBox.Show("请输入需要查看的学生学号", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            }
          
        }
        // 添加学生
        private void button2_Click(object sender, EventArgs e)
        {
            Addstu add = new Addstu();
            add.Show();
            NEW_LOAD(null, null);
        
        }
        //修改学生
        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox_sno.Text != "")
            {

                string str = "SELECT * FROM XS WHERE ID ='" + textBox_sno.Text.ToString() + "';";
                MySqlCommand pcmd = new MySqlCommand(str, conn);
                MySqlDataReader dr = pcmd.ExecuteReader(); //用DataReader 读数据
                if (dr.Read()) //判断是否有该学生
                {
                    Upstu up = new Upstu(textBox_sno.Text.ToString());
                    up.Show();
                }
                else
                {
                    MessageBox.Show("无此学生！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                dr.Close();
            }
            else
            {
                MessageBox.Show("请输入需要修改的学生学号", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            NEW_LOAD(null, null);
            Choose_Load(null, null);
 
        }
        //删除该学生

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox_sno.Text != "")
            {
                string str = "SELECT * FROM XS WHERE ID ='" + textBox_sno.Text.ToString() + "';";
                MySqlCommand pcmd = new MySqlCommand(str, conn);
                MySqlDataReader dr = pcmd.ExecuteReader(); //用DataReader 读数据
                if (dr.Read()) //判断是否有该学生
                {
                    dr.Close();
                    try
                    {
                        sno = textBox_sno.Text.ToString();
                        string str1 = "DELETE FROM XS WHERE ID='" + sno + "'";
                        MySqlCommand cmd = new MySqlCommand(str1, conn);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("删除成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    catch
                    {
                        MessageBox.Show("错误！该学生还成绩未被删除！！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
 
                    }
                }
                else
                {
                    MessageBox.Show("无此学生！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                dr.Close();
                
            }
            else
            {
                MessageBox.Show("请输入需要删除的学生学号", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            NEW_LOAD(null, null);


        }
        //显示所有学生
        private void Choose_Load(object sender, EventArgs e)
        {
            NEW_LOAD(null, null);
        }
        public void NEW_LOAD(object sender,EventArgs e)
        {
            string kcm = "SELECT ID AS 学号, XM AS 姓名, CSSJ AS 出生时间, KCS AS 课程数 FROM XS";

            MySqlDataAdapter da = new MySqlDataAdapter(kcm, conn);// 打开数据适配器（用于读取数据）
            DataSet ds = new DataSet();//创建数据表
            da.Fill(ds);
            dataGridView_stu.DataSource = ds.Tables[0];// 把dataset 与dataGridView_xmcj数据绑定一起
            textBox_sno.Text = "";
        }


        private void button5_Click_1(object sender, EventArgs e)
        {
            conn.Close();
            this.Hide();
            return;
        }
    }
}
