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
    public partial class AddCJ : Form
    {
        static string conflg = "database=pxscj;" +
                        "datasource = 127.0.0.1;" +
                        "userid = root;" +
                        "port=3306;" +
                        "password=55555"; //数据库连接字段
        MySqlConnection conn = new MySqlConnection(conflg);// 数据库连接
        public AddCJ(string id)
        {
            InitializeComponent();
            label2.Text = id;
            this.StartPosition = FormStartPosition.CenterScreen;
            try
            { conn.Open(); }
            catch
            {
                MessageBox.Show("数据库连接失败!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
        }
        //初始化加载课程名
        private void AddCJ_Load(object sender, EventArgs e)
        {
            
            string str = "SELECT KCM FROM KC";
            MySqlDataAdapter pcmd = new MySqlDataAdapter(str, conn);
            DataSet da = new DataSet();
            comboBox_KC.Items.Add("请选择");
            pcmd.Fill(da, "KCM");
            for(int i = 0; i<da.Tables["KCM"].Rows.Count;i++)
            {
                comboBox_KC.Items.Add(da.Tables["KCM"].Rows[i][0].ToString());
            }
            comboBox_KC.SelectedIndex = 0;//默认初始显示
            textBox_cj.Text = "";
            return;
        }

        private void comboBox_KC_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        // 确定按钮事件
        private void button_yes_Click(object sender, EventArgs e)
        {
            try
            {

                
                string cj = textBox_cj.Text.ToString();
                //接收combox的选择结果
                int kc = comboBox_KC.SelectedIndex;
                string str = "INSERT INTO CJ VALUES('" + label2.Text + "','" + kc + "','" + cj + "')";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("添加成功!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch
            {
                MessageBox.Show("添加失败!请检查信息!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Close();
            this.Hide();
      

        }
    }
}
