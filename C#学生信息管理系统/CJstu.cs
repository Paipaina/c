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
    public partial class CJstu : Form
    {
        static string conflg = "database=pxscj;" +
                        "datasource = 127.0.0.1;" +
                        "userid = root;" +
                        "port=3306;" +
                        "password=55555"; //数据库连接字段
        MySqlConnection conn = new MySqlConnection(conflg);
        public CJstu()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            //数据库连接
            try
            { conn.Open(); }
            catch
            {
                MessageBox.Show("数据库连接失败!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }

        }
        // 删除成绩
        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox_Sno.Text != "")
            {
                string str = "SELECT * FROM XS WHERE ID ='" + textBox_Sno.Text.ToString() + "';";
                MySqlCommand pcmd = new MySqlCommand(str, conn);
                MySqlDataReader dr = pcmd.ExecuteReader(); //用DataReader 读数据
                if (dr.Read()) //判断是否有该学生
                {
                    DelCJ dj = new DelCJ(textBox_Sno.Text.ToString());
                    dj.Show();
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
            NEW_LOAD(null, null);
           
        }
        // 添加成绩
        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox_Sno.Text != "")
            {
                string str = "SELECT * FROM XS WHERE ID ='" + textBox_Sno.Text.ToString() + "';";
                MySqlCommand pcmd = new MySqlCommand(str, conn);
                MySqlDataReader dr = pcmd.ExecuteReader(); //用DataReader 读数据
                if (dr.Read()) //判断是否有该学生
                {
                    AddCJ ac = new AddCJ(textBox_Sno.Text.ToString());
                    ac.Show();
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
            NEW_LOAD(null, null);
   
        }
        // 课程管理
        private void button3_Click(object sender, EventArgs e)
        {
            UpKC kc = new UpKC();
            kc.Show();
            NEW_LOAD(null, null);
            return;
        }
        //页面加载
        private void CJstu_Load(object sender, EventArgs e)
        {
            NEW_LOAD(null, null);
  
        }
        // 显示所有学生的已学的课程
        public void NEW_LOAD(object sender, EventArgs e)
        {
            string kcm = "SELECT XS.ID AS 学号, XS.XM AS 姓名,KC.KCM AS 已修课程,CJ.CJ AS 成绩 FROM XS,CJ,KC WHERE XS.ID=CJ.ID AND CJ.KCH=KC.KCH";

            MySqlDataAdapter da = new MySqlDataAdapter(kcm, conn);// 打开数据适配器（用于读取数据）
            DataSet ds = new DataSet();//创建数据表
            da.Fill(ds);
            dataGridView_stu.DataSource = ds.Tables[0];// 把dataset 与dataGridView_xmcj数据绑定一起
            textBox_Sno.Text = "";
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Close();
            this.Hide();
            return;
        }
    }
}
