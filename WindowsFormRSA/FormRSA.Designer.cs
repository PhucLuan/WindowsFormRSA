namespace WindowsFormRSA
{
    partial class FormRSA
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAutoGenP = new System.Windows.Forms.Button();
            this.btnGenKey = new System.Windows.Forms.Button();
            this.txtPublicKey = new System.Windows.Forms.TextBox();
            this.txtPrivateKey = new System.Windows.Forms.TextBox();
            this.txtQ = new System.Windows.Forms.TextBox();
            this.txtP = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSign = new System.Windows.Forms.Button();
            this.btnResultSign = new System.Windows.Forms.Button();
            this.btnSelectSign = new System.Windows.Forms.Button();
            this.txtResultSign = new System.Windows.Forms.TextBox();
            this.txtDocSign = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnAuthen = new System.Windows.Forms.Button();
            this.btnResultAuthen = new System.Windows.Forms.Button();
            this.btnSelectAuthen = new System.Windows.Forms.Button();
            this.txtResultAuthen = new System.Windows.Forms.TextBox();
            this.txtDocAuthen = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.btnAutoGenP);
            this.groupBox1.Controls.Add(this.btnGenKey);
            this.groupBox1.Controls.Add(this.txtPublicKey);
            this.groupBox1.Controls.Add(this.txtPrivateKey);
            this.groupBox1.Controls.Add(this.txtQ);
            this.groupBox1.Controls.Add(this.txtP);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(63, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(530, 144);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SINH KHÓA";
            // 
            // btnAutoGenP
            // 
            this.btnAutoGenP.Location = new System.Drawing.Point(314, 121);
            this.btnAutoGenP.Name = "btnAutoGenP";
            this.btnAutoGenP.Size = new System.Drawing.Size(100, 23);
            this.btnAutoGenP.TabIndex = 10;
            this.btnAutoGenP.Text = "Ngẫu nhiên";
            this.btnAutoGenP.UseVisualStyleBackColor = true;
            this.btnAutoGenP.Click += new System.EventHandler(this.btnAutoGenP_Click);
            // 
            // btnGenKey
            // 
            this.btnGenKey.Location = new System.Drawing.Point(420, 121);
            this.btnGenKey.Name = "btnGenKey";
            this.btnGenKey.Size = new System.Drawing.Size(100, 23);
            this.btnGenKey.TabIndex = 9;
            this.btnGenKey.Text = "Sinh Khóa";
            this.btnGenKey.UseVisualStyleBackColor = true;
            this.btnGenKey.Click += new System.EventHandler(this.btnGenKey_Click);
            // 
            // txtPublicKey
            // 
            this.txtPublicKey.Location = new System.Drawing.Point(420, 89);
            this.txtPublicKey.Name = "txtPublicKey";
            this.txtPublicKey.Size = new System.Drawing.Size(100, 20);
            this.txtPublicKey.TabIndex = 8;
            // 
            // txtPrivateKey
            // 
            this.txtPrivateKey.Location = new System.Drawing.Point(102, 90);
            this.txtPrivateKey.Name = "txtPrivateKey";
            this.txtPrivateKey.PasswordChar = '*';
            this.txtPrivateKey.Size = new System.Drawing.Size(100, 20);
            this.txtPrivateKey.TabIndex = 7;
            // 
            // txtQ
            // 
            this.txtQ.Location = new System.Drawing.Point(420, 36);
            this.txtQ.Name = "txtQ";
            this.txtQ.Size = new System.Drawing.Size(100, 20);
            this.txtQ.TabIndex = 6;
            // 
            // txtP
            // 
            this.txtP.Location = new System.Drawing.Point(293, 36);
            this.txtP.Name = "txtP";
            this.txtP.Size = new System.Drawing.Size(100, 20);
            this.txtP.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(399, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Q";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(273, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "P";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(290, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Khóa công khai";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "2. Khóa bí mật";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "1.Chọn 2 số nguyên tố ngẫu nhiên:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSign);
            this.groupBox2.Controls.Add(this.btnResultSign);
            this.groupBox2.Controls.Add(this.btnSelectSign);
            this.groupBox2.Controls.Add(this.txtResultSign);
            this.groupBox2.Controls.Add(this.txtDocSign);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(63, 212);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(530, 120);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "KÝ VĂN BẢN";
            // 
            // btnSign
            // 
            this.btnSign.Location = new System.Drawing.Point(424, 97);
            this.btnSign.Name = "btnSign";
            this.btnSign.Size = new System.Drawing.Size(96, 23);
            this.btnSign.TabIndex = 13;
            this.btnSign.Text = "Ký văn bản";
            this.btnSign.UseVisualStyleBackColor = true;
            this.btnSign.Click += new System.EventHandler(this.btnSign_Click);
            // 
            // btnResultSign
            // 
            this.btnResultSign.Location = new System.Drawing.Point(318, 97);
            this.btnResultSign.Name = "btnResultSign";
            this.btnResultSign.Size = new System.Drawing.Size(96, 23);
            this.btnResultSign.TabIndex = 12;
            this.btnResultSign.Text = "Xuất kết quả";
            this.btnResultSign.UseVisualStyleBackColor = true;
            this.btnResultSign.Click += new System.EventHandler(this.btnResultSign_Click);
            // 
            // btnSelectSign
            // 
            this.btnSelectSign.Location = new System.Drawing.Point(445, 25);
            this.btnSelectSign.Name = "btnSelectSign";
            this.btnSelectSign.Size = new System.Drawing.Size(75, 23);
            this.btnSelectSign.TabIndex = 11;
            this.btnSelectSign.Text = "Chọn";
            this.btnSelectSign.UseVisualStyleBackColor = true;
            this.btnSelectSign.Click += new System.EventHandler(this.btnSelectSign_Click);
            // 
            // txtResultSign
            // 
            this.txtResultSign.Location = new System.Drawing.Point(116, 61);
            this.txtResultSign.Name = "txtResultSign";
            this.txtResultSign.Size = new System.Drawing.Size(404, 20);
            this.txtResultSign.TabIndex = 10;
            // 
            // txtDocSign
            // 
            this.txtDocSign.Location = new System.Drawing.Point(116, 27);
            this.txtDocSign.Name = "txtDocSign";
            this.txtDocSign.Size = new System.Drawing.Size(309, 20);
            this.txtDocSign.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Kết quả:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Văn bản:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnAuthen);
            this.groupBox3.Controls.Add(this.btnResultAuthen);
            this.groupBox3.Controls.Add(this.btnSelectAuthen);
            this.groupBox3.Controls.Add(this.txtResultAuthen);
            this.groupBox3.Controls.Add(this.txtDocAuthen);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Location = new System.Drawing.Point(63, 350);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(530, 120);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "XÁC THỰC CHỮ KÝ";
            // 
            // btnAuthen
            // 
            this.btnAuthen.Location = new System.Drawing.Point(424, 97);
            this.btnAuthen.Name = "btnAuthen";
            this.btnAuthen.Size = new System.Drawing.Size(96, 23);
            this.btnAuthen.TabIndex = 15;
            this.btnAuthen.Text = "Xác thực";
            this.btnAuthen.UseVisualStyleBackColor = true;
            this.btnAuthen.Click += new System.EventHandler(this.btnAuthen_Click);
            // 
            // btnResultAuthen
            // 
            this.btnResultAuthen.Location = new System.Drawing.Point(318, 97);
            this.btnResultAuthen.Name = "btnResultAuthen";
            this.btnResultAuthen.Size = new System.Drawing.Size(96, 23);
            this.btnResultAuthen.TabIndex = 14;
            this.btnResultAuthen.Text = "Xuất kết quả";
            this.btnResultAuthen.UseVisualStyleBackColor = true;
            this.btnResultAuthen.Click += new System.EventHandler(this.btnResultAuthen_Click);
            // 
            // btnSelectAuthen
            // 
            this.btnSelectAuthen.Location = new System.Drawing.Point(445, 24);
            this.btnSelectAuthen.Name = "btnSelectAuthen";
            this.btnSelectAuthen.Size = new System.Drawing.Size(75, 23);
            this.btnSelectAuthen.TabIndex = 12;
            this.btnSelectAuthen.Text = "Chọn";
            this.btnSelectAuthen.UseVisualStyleBackColor = true;
            this.btnSelectAuthen.Click += new System.EventHandler(this.btnSelectAuthen_Click);
            // 
            // txtResultAuthen
            // 
            this.txtResultAuthen.Location = new System.Drawing.Point(116, 61);
            this.txtResultAuthen.Name = "txtResultAuthen";
            this.txtResultAuthen.Size = new System.Drawing.Size(404, 20);
            this.txtResultAuthen.TabIndex = 10;
            // 
            // txtDocAuthen
            // 
            this.txtDocAuthen.Location = new System.Drawing.Point(116, 27);
            this.txtDocAuthen.Name = "txtDocAuthen";
            this.txtDocAuthen.Size = new System.Drawing.Size(309, 20);
            this.txtDocAuthen.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Kết quả:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Văn bản:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(208, 92);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(48, 17);
            this.checkBox1.TabIndex = 11;
            this.checkBox1.Text = "Hiện";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // FormRSA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 493);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormRSA";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtQ;
        private System.Windows.Forms.TextBox txtP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPublicKey;
        private System.Windows.Forms.TextBox txtPrivateKey;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSign;
        private System.Windows.Forms.Button btnResultSign;
        private System.Windows.Forms.Button btnSelectSign;
        private System.Windows.Forms.TextBox txtResultSign;
        private System.Windows.Forms.TextBox txtDocSign;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnAuthen;
        private System.Windows.Forms.Button btnResultAuthen;
        private System.Windows.Forms.Button btnSelectAuthen;
        private System.Windows.Forms.TextBox txtResultAuthen;
        private System.Windows.Forms.TextBox txtDocAuthen;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnGenKey;
        private System.Windows.Forms.Button btnAutoGenP;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

