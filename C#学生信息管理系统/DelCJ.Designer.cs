namespace pxscj
{
    partial class DelCJ
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
            this.comboBox_KC = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button_yes = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox_KC
            // 
            this.comboBox_KC.FormattingEnabled = true;
            this.comboBox_KC.Location = new System.Drawing.Point(92, 150);
            this.comboBox_KC.Name = "comboBox_KC";
            this.comboBox_KC.Size = new System.Drawing.Size(130, 23);
            this.comboBox_KC.TabIndex = 136;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 15);
            this.label3.TabIndex = 133;
            this.label3.Text = "选择课程:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(154, 255);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 46);
            this.button1.TabIndex = 132;
            this.button1.Text = "返回";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_yes
            // 
            this.button_yes.Location = new System.Drawing.Point(14, 255);
            this.button_yes.Name = "button_yes";
            this.button_yes.Size = new System.Drawing.Size(83, 46);
            this.button_yes.TabIndex = 131;
            this.button_yes.Text = "确定";
            this.button_yes.UseVisualStyleBackColor = true;
            this.button_yes.Click += new System.EventHandler(this.button_yes_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 130;
            this.label1.Text = "学号：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 137;
            this.label2.Text = "label2";
            // 
            // DelCJ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox_KC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_yes);
            this.Controls.Add(this.label1);
            this.Name = "DelCJ";
            this.Text = "DelCJ";
            this.Load += new System.EventHandler(this.DelCJ_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBox_KC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_yes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}