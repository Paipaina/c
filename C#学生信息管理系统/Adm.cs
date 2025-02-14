using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pxscj
{
    public partial class Adm : Form
    {
        public Adm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        //查看学生按钮事件响应
        private void stubutton_Click(object sender, EventArgs e)
        {
            Choose cs = new Choose();
            cs.Show();

        }
        // 成绩管理
        private void CJ_button_Click(object sender, EventArgs e)
        {
            CJstu stu = new CJstu();
            stu.Show();
  
        }
        //退出
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            return;
        }
    }
}
