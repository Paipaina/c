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
    public partial class DelCJ : Form
    {
        static string conflg = "database=pxscj;" +
                      "datasource = 127.0.0.1;" +
                      "userid = root;" +
                      "port=3306;" +
                      "password=55555"; //数据库连接字段
        MySqlConnection conn = new MySqlConnection(conflg);
        public DelCJ(string id)
        {
            InitializeComponent();
            label2.Text = id;
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
        // 显示该学生已修课程
        private void DelCJ_Load(object sender, EventArgs e)
        {
            NEW(null,null);
        }
        private void NEW(object sender, EventArgs e)
        {
            string str = "SELECT KCM FROM KC,CJ WHERE CJ.ID='" + label2.Text + "' AND CJ.KCH=KC.KCH";
            MySqlDataAdapter pcmd = new MySqlDataAdapter(str, conn);
            DataSet da = new DataSet();
            comboBox_KC.Items.Add("请选择");
            pcmd.Fill(da, "KCM");
            for (int i = 0; i < da.Tables["KCM"].Rows.Count; i++)
            {
                comboBox_KC.Items.Add(da.Tables["KCM"].Rows[i][0].ToString());
            }
            comboBox_KC.SelectedIndex = 0;//默认初始显示
            
            return;
        }
        // 确认按钮事件
        private void button_yes_Click(object sender, EventArgs e)
        {
            try
            {
                string kcs = comboBox_KC.SelectedIndex.ToString();
                string str = "DELETE FROM CJ WHERE CJ.ID='" + label2.Text + "' AND KCH='" + kcs + "'";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("删除成功!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch
            {
                MessageBox.Show("删除失败!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Close();
            this.Hide();
            return;
        }
    }
}
