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
using System.IO;

namespace pxscj
{
    public partial class Stu : Form
    {
        static string config = "database=pxscj;" +
                        "datasource = 127.0.0.1;" +
                        "userid = root;" +
                        "port=3306;" +
                        "password=55555"; //数据库连接字段

        private static string path = ""; //照片文件的路径
        MySqlConnection conn = new MySqlConnection(config);
        public Stu(string id)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            label1.Text = id;
            try
            { conn.Open(); }
            catch
            {
                MessageBox.Show("数据库连接失败!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.Hide();
                return;
            }
        }
        //显示所有
        private void Stu_Load(object sender, EventArgs e)
        {
            //显示个人信息
            DataSet myDs = new DataSet();
            string mySqlStr = "select * from XS where ID=" + label1.Text.ToString() + ";";
            MySqlCommand cmd = new MySqlCommand(mySqlStr, conn); //语句
            MySqlDataReader dr = cmd.ExecuteReader(); //用DataReader 读数据
                if (dr.Read())
                {
                    label2.Text = dr.GetString(1).ToString();//将数据传入各个框中
                    if (dr.GetString(2).ToString() == "1")// 判断性别
                        label3.Text = "男";
                    else
                        label3.Text = "女";
                    label4.Text = dr.GetString(3).ToString();
                    label5.Text = dr.GetString(4).ToString();
                
            }
            dr.Close();

            // 显示所学课程名
            string kcm = "SELECT KC.KCM AS 课程名,CJ AS 成绩 FROM CJ,KC  where ID='" + label1.Text.ToString() + "'AND KC.KCH=CJ.KCH";
            MySqlDataAdapter da = new MySqlDataAdapter(kcm, conn);// 打开数据适配器（用于读取数据）
            DataSet ds = new DataSet();//创建数据表
            da.Fill(ds);
            dataGridView_kccj.DataSource = ds.Tables[0];// 把dataset 与dataGridView_xmcj数据绑定一起
            // 显示图片
            //调用方法
            string photo = "SELECT ZP FROM XS WHERE ID=" + label1.Text.ToString() + ";";
            MySqlCommand pcmd = new MySqlCommand(photo, conn);//执行语句
            try //尝试执行，如果执行不通过则该学生没有照片
            {
                byte[] b = (byte[])pcmd.ExecuteScalar();// 将照片的二进制读取保存
                MemoryStream stream = new MemoryStream(b, true); // 字节数组对象
                stream.Write(b, 0, b.Length);
                pictureBox_stu.Image = new Bitmap(stream);//将图片保存至PictureBox中
                stream.Close();//关闭绘画
            }
            catch
            {
                pictureBox_stu.Image = null;
            }
            conn.Close();
            return;
        }
    }
 
}
