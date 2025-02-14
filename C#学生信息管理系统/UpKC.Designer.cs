namespace pxscj
{
    partial class UpKC
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
            this.button_yes = new System.Windows.Forms.Button();
            this.dataGridView_kc = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_kc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_kc)).BeginInit();
            this.SuspendLayout();
            // 
            // button_yes
            // 
            this.button_yes.Location = new System.Drawing.Point(27, 380);
            this.button_yes.Name = "button_yes";
            this.button_yes.Size = new System.Drawing.Size(83, 46);
            this.button_yes.TabIndex = 122;
            this.button_yes.Text = "添加";
            this.button_yes.UseVisualStyleBackColor = true;
            this.button_yes.Click += new System.EventHandler(this.button_yes_Click);
            // 
            // dataGridView_kc
            // 
            this.dataGridView_kc.AllowUserToResizeColumns = false;
            this.dataGridView_kc.AllowUserToResizeRows = false;
            this.dataGridView_kc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_kc.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView_kc.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView_kc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_kc.Location = new System.Drawing.Point(27, 68);
            this.dataGridView_kc.Name = "dataGridView_kc";
            this.dataGridView_kc.ReadOnly = true;
            this.dataGridView_kc.RowHeadersVisible = false;
            this.dataGridView_kc.RowTemplate.Height = 27;
            this.dataGridView_kc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView_kc.Size = new System.Drawing.Size(298, 233);
            this.dataGridView_kc.TabIndex = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 335);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 126;
            this.label1.Text = "课程名：";
            // 
            // textBox_kc
            // 
            this.textBox_kc.Location = new System.Drawing.Point(88, 325);
            this.textBox_kc.Name = "textBox_kc";
            this.textBox_kc.Size = new System.Drawing.Size(178, 25);
            this.textBox_kc.TabIndex = 127;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 15);
            this.label2.TabIndex = 128;
            this.label2.Text = "当前所有课程";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(139, 380);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 46);
            this.button2.TabIndex = 129;
            this.button2.Text = "删除";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(250, 380);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 46);
            this.button1.TabIndex = 130;
            this.button1.Text = "返回";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UpKC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_kc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView_kc);
            this.Controls.Add(this.button_yes);
            this.Name = "UpKC";
            this.Text = "UpKC";
            this.Load += new System.EventHandler(this.UpKC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_kc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_yes;
        private System.Windows.Forms.DataGridView dataGridView_kc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_kc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}