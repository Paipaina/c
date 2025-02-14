namespace pxscj
{
    partial class Adm
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
            this.stubutton = new System.Windows.Forms.Button();
            this.CJ_button = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // stubutton
            // 
            this.stubutton.Location = new System.Drawing.Point(70, 64);
            this.stubutton.Name = "stubutton";
            this.stubutton.Size = new System.Drawing.Size(141, 51);
            this.stubutton.TabIndex = 0;
            this.stubutton.Text = "学生管理";
            this.stubutton.UseVisualStyleBackColor = true;
            this.stubutton.Click += new System.EventHandler(this.stubutton_Click);
            // 
            // CJ_button
            // 
            this.CJ_button.Location = new System.Drawing.Point(70, 158);
            this.CJ_button.Name = "CJ_button";
            this.CJ_button.Size = new System.Drawing.Size(141, 71);
            this.CJ_button.TabIndex = 1;
            this.CJ_button.Text = "成绩管理";
            this.CJ_button.UseVisualStyleBackColor = true;
            this.CJ_button.Click += new System.EventHandler(this.CJ_button_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(70, 289);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 59);
            this.button1.TabIndex = 2;
            this.button1.Text = "退出";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Adm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 380);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CJ_button);
            this.Controls.Add(this.stubutton);
            this.Name = "Adm";
            this.Text = "Adm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button stubutton;
        private System.Windows.Forms.Button CJ_button;
        private System.Windows.Forms.Button button1;
    }
}