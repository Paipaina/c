namespace pxscj
{
    partial class CJstu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView_stu = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Sno = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_stu)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_stu
            // 
            this.dataGridView_stu.AllowUserToResizeColumns = false;
            this.dataGridView_stu.AllowUserToResizeRows = false;
            this.dataGridView_stu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_stu.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView_stu.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView_stu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_stu.Location = new System.Drawing.Point(69, 77);
            this.dataGridView_stu.Name = "dataGridView_stu";
            this.dataGridView_stu.ReadOnly = true;
            this.dataGridView_stu.RowHeadersVisible = false;
            this.dataGridView_stu.RowTemplate.Height = 27;
            this.dataGridView_stu.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView_stu.ShowRowErrors = false;
            this.dataGridView_stu.Size = new System.Drawing.Size(612, 281);
            this.dataGridView_stu.TabIndex = 83;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(413, 378);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(87, 49);
            this.button4.TabIndex = 81;
            this.button4.Text = "删除";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(268, 378);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(84, 49);
            this.button3.TabIndex = 80;
            this.button3.Text = "课程管理";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(115, 378);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(76, 49);
            this.button2.TabIndex = 78;
            this.button2.Text = "添加成绩";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 84;
            this.label1.Text = "学号：";
            // 
            // textBox_Sno
            // 
            this.textBox_Sno.Location = new System.Drawing.Point(149, 26);
            this.textBox_Sno.Name = "textBox_Sno";
            this.textBox_Sno.Size = new System.Drawing.Size(294, 25);
            this.textBox_Sno.TabIndex = 85;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(568, 378);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 49);
            this.button1.TabIndex = 86;
            this.button1.Text = "返回";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CJstu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox_Sno);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView_stu);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Name = "CJstu";
            this.Text = "CJstu";
            this.Load += new System.EventHandler(this.CJstu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_stu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_stu;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Sno;
        private System.Windows.Forms.Button button1;
    }
}