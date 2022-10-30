namespace htai
{
    partial class Form1
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
            this.tbSoA = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbSoB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbKQ = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btCong = new System.Windows.Forms.Button();
            this.tbTru = new System.Windows.Forms.Button();
            this.lb = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btChia = new System.Windows.Forms.Button();
            this.btNhan = new System.Windows.Forms.Button();
            this.btSoSanh = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbSoA
            // 
            this.tbSoA.Location = new System.Drawing.Point(213, 45);
            this.tbSoA.Name = "tbSoA";
            this.tbSoA.Size = new System.Drawing.Size(283, 38);
            this.tbSoA.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "So A";
            // 
            // tbSoB
            // 
            this.tbSoB.Location = new System.Drawing.Point(213, 105);
            this.tbSoB.Name = "tbSoB";
            this.tbSoB.Size = new System.Drawing.Size(283, 38);
            this.tbSoB.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "So B";
            // 
            // tbKQ
            // 
            this.tbKQ.Location = new System.Drawing.Point(213, 165);
            this.tbKQ.Name = "tbKQ";
            this.tbKQ.Size = new System.Drawing.Size(283, 38);
            this.tbKQ.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 31);
            this.label3.TabIndex = 1;
            this.label3.Text = "KetQua";
            // 
            // btCong
            // 
            this.btCong.Location = new System.Drawing.Point(44, 253);
            this.btCong.Name = "btCong";
            this.btCong.Size = new System.Drawing.Size(128, 47);
            this.btCong.TabIndex = 2;
            this.btCong.Text = "Cong";
            this.btCong.UseVisualStyleBackColor = true;
            this.btCong.Click += new System.EventHandler(this.btCong_Click);
            // 
            // tbTru
            // 
            this.tbTru.Location = new System.Drawing.Point(193, 250);
            this.tbTru.Name = "tbTru";
            this.tbTru.Size = new System.Drawing.Size(138, 50);
            this.tbTru.TabIndex = 3;
            this.tbTru.Text = "Tru";
            this.tbTru.UseVisualStyleBackColor = true;
            this.tbTru.Click += new System.EventHandler(this.tbTru_Click);
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb.Location = new System.Drawing.Point(143, 44);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(568, 36);
            this.lb.TabIndex = 4;
            this.lb.Text = "CHƯƠNG TRÌNH TÍNH TOÁN ĐƠN GIẢN";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btSoSanh);
            this.groupBox1.Controls.Add(this.btChia);
            this.groupBox1.Controls.Add(this.btNhan);
            this.groupBox1.Controls.Add(this.tbTru);
            this.groupBox1.Controls.Add(this.btCong);
            this.groupBox1.Controls.Add(this.tbSoA);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbKQ);
            this.groupBox1.Controls.Add(this.tbSoB);
            this.groupBox1.Location = new System.Drawing.Point(95, 142);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(692, 332);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tính Toán Đơn Giản";
            // 
            // btChia
            // 
            this.btChia.Location = new System.Drawing.Point(490, 250);
            this.btChia.Name = "btChia";
            this.btChia.Size = new System.Drawing.Size(138, 50);
            this.btChia.TabIndex = 3;
            this.btChia.Text = "Chia";
            this.btChia.UseVisualStyleBackColor = true;
            this.btChia.Click += new System.EventHandler(this.btChia_Click);
            // 
            // btNhan
            // 
            this.btNhan.Location = new System.Drawing.Point(337, 250);
            this.btNhan.Name = "btNhan";
            this.btNhan.Size = new System.Drawing.Size(138, 50);
            this.btNhan.TabIndex = 3;
            this.btNhan.Text = "Nhan";
            this.btNhan.UseVisualStyleBackColor = true;
            this.btNhan.Click += new System.EventHandler(this.btNhan_Click);
            // 
            // btSoSanh
            // 
            this.btSoSanh.Location = new System.Drawing.Point(535, 98);
            this.btSoSanh.Name = "btSoSanh";
            this.btSoSanh.Size = new System.Drawing.Size(138, 50);
            this.btSoSanh.TabIndex = 3;
            this.btSoSanh.Text = "So Sanh";
            this.btSoSanh.UseVisualStyleBackColor = true;
            this.btSoSanh.Click += new System.EventHandler(this.btSoSanh_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 622);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lb);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(8);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbSoA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbSoB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbKQ;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btCong;
        private System.Windows.Forms.Button tbTru;
        private System.Windows.Forms.Label lb;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btChia;
        private System.Windows.Forms.Button btNhan;
        private System.Windows.Forms.Button btSoSanh;
    }
}

