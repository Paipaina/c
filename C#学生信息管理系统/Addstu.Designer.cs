namespace pxscj
{
    partial class Addstu
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
            this.pictureBox_stu = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.textBox_cssj = new System.Windows.Forms.TextBox();
            this.radioButton_male = new System.Windows.Forms.RadioButton();
            this.radioButton_female = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.button_selectphoto = new System.Windows.Forms.Button();
            this.button_yes = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_stu)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_stu
            // 
            this.pictureBox_stu.Location = new System.Drawing.Point(216, 208);
            this.pictureBox_stu.Name = "pictureBox_stu";
            this.pictureBox_stu.Size = new System.Drawing.Size(144, 151);
            this.pictureBox_stu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_stu.TabIndex = 78;
            this.pictureBox_stu.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 208);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 15);
            this.label8.TabIndex = 77;
            this.label8.Text = "照片：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 164);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 15);
            this.label9.TabIndex = 76;
            this.label9.Text = "出生年月：";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 129);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 15);
            this.label10.TabIndex = 75;
            this.label10.Text = "性别：";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 82);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 15);
            this.label11.TabIndex = 74;
            this.label11.Text = "姓名：";
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(89, 79);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(189, 25);
            this.textBox_name.TabIndex = 79;
            // 
            // textBox_cssj
            // 
            this.textBox_cssj.Location = new System.Drawing.Point(89, 154);
            this.textBox_cssj.Name = "textBox_cssj";
            this.textBox_cssj.Size = new System.Drawing.Size(189, 25);
            this.textBox_cssj.TabIndex = 80;
            // 
            // radioButton_male
            // 
            this.radioButton_male.AutoSize = true;
            this.radioButton_male.Location = new System.Drawing.Point(89, 127);
            this.radioButton_male.Name = "radioButton_male";
            this.radioButton_male.Size = new System.Drawing.Size(43, 19);
            this.radioButton_male.TabIndex = 81;
            this.radioButton_male.TabStop = true;
            this.radioButton_male.Text = "男";
            this.radioButton_male.UseVisualStyleBackColor = true;
            // 
            // radioButton_female
            // 
            this.radioButton_female.AutoSize = true;
            this.radioButton_female.Location = new System.Drawing.Point(153, 125);
            this.radioButton_female.Name = "radioButton_female";
            this.radioButton_female.Size = new System.Drawing.Size(43, 19);
            this.radioButton_female.TabIndex = 82;
            this.radioButton_female.TabStop = true;
            this.radioButton_female.Text = "女";
            this.radioButton_female.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 83;
            this.label1.Text = "学号：";
            // 
            // textBox_id
            // 
            this.textBox_id.Location = new System.Drawing.Point(89, 36);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(189, 25);
            this.textBox_id.TabIndex = 84;
            // 
            // button_selectphoto
            // 
            this.button_selectphoto.Location = new System.Drawing.Point(79, 200);
            this.button_selectphoto.Name = "button_selectphoto";
            this.button_selectphoto.Size = new System.Drawing.Size(117, 23);
            this.button_selectphoto.TabIndex = 85;
            this.button_selectphoto.Text = "选择文件..........";
            this.button_selectphoto.UseVisualStyleBackColor = true;
            this.button_selectphoto.Click += new System.EventHandler(this.button_selectphoto_Click);
            // 
            // button_yes
            // 
            this.button_yes.Location = new System.Drawing.Point(79, 339);
            this.button_yes.Name = "button_yes";
            this.button_yes.Size = new System.Drawing.Size(83, 46);
            this.button_yes.TabIndex = 86;
            this.button_yes.Text = "确定";
            this.button_yes.UseVisualStyleBackColor = true;
            this.button_yes.Click += new System.EventHandler(this.button_yes_Click);
            // 
            // Addstu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 406);
            this.Controls.Add(this.button_yes);
            this.Controls.Add(this.button_selectphoto);
            this.Controls.Add(this.textBox_id);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioButton_female);
            this.Controls.Add(this.radioButton_male);
            this.Controls.Add(this.textBox_cssj);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.pictureBox_stu);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Name = "Addstu";
            this.Text = "Addstu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_stu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_stu;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.TextBox textBox_cssj;
        private System.Windows.Forms.RadioButton radioButton_male;
        private System.Windows.Forms.RadioButton radioButton_female;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.Button button_selectphoto;
        private System.Windows.Forms.Button button_yes;
    }
}