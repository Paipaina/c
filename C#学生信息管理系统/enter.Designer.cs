namespace pxscj
{
    partial class Enter
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.user_label = new System.Windows.Forms.Label();
            this.paw_label = new System.Windows.Forms.Label();
            this.name_textBox = new System.Windows.Forms.TextBox();
            this.paw_textBox = new System.Windows.Forms.TextBox();
            this.Enter_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // user_label
            // 
            this.user_label.AutoSize = true;
            this.user_label.Location = new System.Drawing.Point(40, 80);
            this.user_label.Name = "user_label";
            this.user_label.Size = new System.Drawing.Size(67, 15);
            this.user_label.TabIndex = 0;
            this.user_label.Text = "用户名：";
            // 
            // paw_label
            // 
            this.paw_label.AutoSize = true;
            this.paw_label.Location = new System.Drawing.Point(40, 177);
            this.paw_label.Name = "paw_label";
            this.paw_label.Size = new System.Drawing.Size(52, 15);
            this.paw_label.TabIndex = 1;
            this.paw_label.Text = "密码：";
            // 
            // name_textBox
            // 
            this.name_textBox.Location = new System.Drawing.Point(113, 70);
            this.name_textBox.Name = "name_textBox";
            this.name_textBox.Size = new System.Drawing.Size(185, 25);
            this.name_textBox.TabIndex = 2;
            // 
            // paw_textBox
            // 
            this.paw_textBox.Location = new System.Drawing.Point(113, 167);
            this.paw_textBox.Name = "paw_textBox";
            this.paw_textBox.Size = new System.Drawing.Size(185, 25);
            this.paw_textBox.TabIndex = 3;
            // 
            // Enter_button
            // 
            this.Enter_button.Location = new System.Drawing.Point(150, 232);
            this.Enter_button.Name = "Enter_button";
            this.Enter_button.Size = new System.Drawing.Size(75, 45);
            this.Enter_button.TabIndex = 4;
            this.Enter_button.Text = "登入";
            this.Enter_button.UseVisualStyleBackColor = true;
            this.Enter_button.Click += new System.EventHandler(this.Enter_button_Click);
            // 
            // Enter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 357);
            this.Controls.Add(this.Enter_button);
            this.Controls.Add(this.paw_textBox);
            this.Controls.Add(this.name_textBox);
            this.Controls.Add(this.paw_label);
            this.Controls.Add(this.user_label);
            this.Name = "Enter";
            this.Text = "登入界面";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label user_label;
        private System.Windows.Forms.Label paw_label;
        private System.Windows.Forms.TextBox name_textBox;
        private System.Windows.Forms.TextBox paw_textBox;
        private System.Windows.Forms.Button Enter_button;
    }
}

