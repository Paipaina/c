﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient;

namespace pxscj
{
    public partial class Addstu : Form
    {
        static string config = "database=pxscj;" +
                        "datasource = 127.0.0.1;" +
                        "userid = root;" +
                        "port=3306;" +
                        "password=55555"; //数据库连接字段

        private static string path = ""; //照片文件的路径
        public Addstu()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        // 添加学生
        private void button_yes_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(config); //连接数据库
                conn.Open(); //打开数据库
                             // 判断信息是否完整
                if (textBox_id.Text == "")
                {
                    MessageBox.Show("学号不能为空", "用户登入", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                }
                else if (textBox_name.Text == "")
                {
                    MessageBox.Show("姓名不能为空", "用户登入", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else if (textBox_cssj.Text == "")
                {
                    MessageBox.Show("出生时间不能为空", "用户登入", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else if (!radioButton_male.Checked && !radioButton_female.Checked)
                {
                    MessageBox.Show("性别不能为空", "用户登入", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    // 保存字段
                    string id = textBox_id.Text.ToString();
                    string name = textBox_name.Text.ToString();
                    string cssj = textBox_cssj.Text.ToString();
                    int xb = 0;//默认性别为女
                    if (radioButton_male.Checked) xb = 1;
                    // 判断有无照片插入（默认为有照片）
                    string str = "INSERT INTO XS VALUES('" + id + "','" + name + "','" + xb + "','" + cssj + "',0,NULL)";
                    if (path != "")
                        str = "INSERT INTO XS VALUES('" + id + "','" + name + "','" + xb + "','" + cssj + "',0,@Photo)";
                    MySqlCommand cmd = new MySqlCommand(str, conn);
                    if (path!="")
                    {
                        FileStream fs = new FileStream(path, FileMode.Open,FileAccess.Read);//将图片以文件流的形式保存
                        byte[] fileBytes = new byte[fs.Length];//创建字节数组
                        BinaryReader br = new BinaryReader(fs);
                        fileBytes = br.ReadBytes(Convert.ToInt32(fs.Length));
                        MySqlParameter mpar = new MySqlParameter("@Photo", SqlDbType.Image);//为命令创建参数
                        mpar.MySqlDbType = MySqlDbType.VarBinary;
                        mpar.Value = fileBytes; //为参数赋值
                        cmd.Parameters.Add(mpar);// 添加参数
                    }
                    //在MYSQl中执行该语句
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("添加成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conn.Close();
                    this.Hide();
                    

                }
            }
            catch
            {
                MessageBox.Show("添加失败,请检查信息", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            return;
        }
        // 选择照片按钮事件
        private void button_selectphoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            //设置接受图片的格式
            openDialog.Filter = "bmp 文件(*.bmp)|bmp|gif 文件(*gif)|*.gif|jpeg 文件(*jpg)|*.jpg";
            openDialog.FilterIndex = 3;
            openDialog.Title = "选择照片";//设置对话框的名称
            if (openDialog.ShowDialog() == DialogResult.OK)
                path = openDialog.FileName;//获取路径
            pictureBox_stu.Image = Image.FromFile(path);
            //MessageBox.Show(path);//测试是否保存该路径

        }
    }
}
