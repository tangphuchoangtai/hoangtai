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
            this.SuspendLayout();
            // 
            // tbSoA
            // 
            this.tbSoA.Location = new System.Drawing.Point(234, 129);
            this.tbSoA.Name = "tbSoA";
            this.tbSoA.Size = new System.Drawing.Size(160, 38);
            this.tbSoA.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(143, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "So A";
            // 
            // tbSoB
            // 
            this.tbSoB.Location = new System.Drawing.Point(234, 185);
            this.tbSoB.Name = "tbSoB";
            this.tbSoB.Size = new System.Drawing.Size(160, 38);
            this.tbSoB.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(143, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "So B";
            // 
            // tbKQ
            // 
            this.tbKQ.Location = new System.Drawing.Point(255, 244);
            this.tbKQ.Name = "tbKQ";
            this.tbKQ.Size = new System.Drawing.Size(160, 38);
            this.tbKQ.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(143, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 31);
            this.label3.TabIndex = 1;
            this.label3.Text = "KetQua";
            // 
            // btCong
            // 
            this.btCong.Location = new System.Drawing.Point(195, 315);
            this.btCong.Name = "btCong";
            this.btCong.Size = new System.Drawing.Size(153, 65);
            this.btCong.TabIndex = 2;
            this.btCong.Text = "Cong";
            this.btCong.UseVisualStyleBackColor = true;
            this.btCong.Click += new System.EventHandler(this.btCong_Click);
            // 
            // tbTru
            // 
            this.tbTru.Location = new System.Drawing.Point(416, 327);
            this.tbTru.Name = "tbTru";
            this.tbTru.Size = new System.Drawing.Size(166, 52);
            this.tbTru.TabIndex = 3;
            this.tbTru.Text = "tru";
            this.tbTru.UseVisualStyleBackColor = true;
            this.tbTru.Click += new System.EventHandler(this.tbTru_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 622);
            this.Controls.Add(this.tbTru);
            this.Controls.Add(this.btCong);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbKQ);
            this.Controls.Add(this.tbSoB);
            this.Controls.Add(this.tbSoA);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(8);
            this.Name = "Form1";
            this.Text = "Form1";
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
    }
}

