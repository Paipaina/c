﻿namespace pxscj
{
    partial class Choose
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox_sno = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView_stu = new System.Windows.Forms.DataGridView();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_stu)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(559, 66);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "查询";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(194, 350);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(76, 49);
            this.button2.TabIndex = 1;
            this.button2.Text = "添加";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox_sno
            // 
            this.textBox_sno.Location = new System.Drawing.Point(285, 73);
            this.textBox_sno.Name = "textBox_sno";
            this.textBox_sno.Size = new System.Drawing.Size(223, 25);
            this.textBox_sno.TabIndex = 2;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(311, 350);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(84, 49);
            this.button3.TabIndex = 4;
            this.button3.Text = "修改";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(430, 350);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(87, 49);
            this.button4.TabIndex = 5;
            this.button4.Text = "删除";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(191, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "学号：";
            // 
            // dataGridView_stu
            // 
            this.dataGridView_stu.AllowUserToResizeColumns = false;
            this.dataGridView_stu.AllowUserToResizeRows = false;
            this.dataGridView_stu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_stu.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView_stu.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView_stu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_stu.Location = new System.Drawing.Point(192, 144);
            this.dataGridView_stu.Name = "dataGridView_stu";
            this.dataGridView_stu.ReadOnly = true;
            this.dataGridView_stu.RowHeadersVisible = false;
            this.dataGridView_stu.RowTemplate.Height = 27;
            this.dataGridView_stu.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView_stu.Size = new System.Drawing.Size(438, 181);
            this.dataGridView_stu.TabIndex = 76;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(559, 350);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 49);
            this.button5.TabIndex = 77;
            this.button5.Text = "返回";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // Choose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 441);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.dataGridView_stu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox_sno);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Choose";
            this.Text = "Choose";
            this.Load += new System.EventHandler(this.Choose_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_stu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox_sno;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView_stu;
        private System.Windows.Forms.Button button5;
    }
}