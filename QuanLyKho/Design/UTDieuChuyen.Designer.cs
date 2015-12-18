namespace QuanLyKho.Design
{
    partial class UTDieuChuyen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lvTKSD = new System.Windows.Forms.ListView();
            this.tbSoLuong = new System.Windows.Forms.TextBox();
            this.tbVatTu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbDenNgay = new System.Windows.Forms.MaskedTextBox();
            this.tbTuNgay = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbDienGiai = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btXemBaoCao = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvTKSD
            // 
            this.lvTKSD.Location = new System.Drawing.Point(22, 15);
            this.lvTKSD.Name = "lvTKSD";
            this.lvTKSD.Size = new System.Drawing.Size(445, 394);
            this.lvTKSD.TabIndex = 70;
            this.lvTKSD.UseCompatibleStateImageBehavior = false;
            this.lvTKSD.SelectedIndexChanged += new System.EventHandler(this.lvTKSD_SelectedIndexChanged);
            // 
            // tbSoLuong
            // 
            this.tbSoLuong.Enabled = false;
            this.tbSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbSoLuong.Location = new System.Drawing.Point(129, 74);
            this.tbSoLuong.Name = "tbSoLuong";
            this.tbSoLuong.Size = new System.Drawing.Size(227, 29);
            this.tbSoLuong.TabIndex = 60;
            // 
            // tbVatTu
            // 
            this.tbVatTu.Enabled = false;
            this.tbVatTu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbVatTu.Location = new System.Drawing.Point(129, 28);
            this.tbVatTu.Name = "tbVatTu";
            this.tbVatTu.Size = new System.Drawing.Size(227, 29);
            this.tbVatTu.TabIndex = 58;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(24, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 57;
            this.label2.Text = "Tên vật tư : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(31, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 20);
            this.label3.TabIndex = 59;
            this.label3.Text = "Số lượng : ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbDenNgay);
            this.groupBox2.Controls.Add(this.tbTuNgay);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(498, 15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(374, 110);
            this.groupBox2.TabIndex = 72;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm kiếm";
            // 
            // tbDenNgay
            // 
            this.tbDenNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbDenNgay.Location = new System.Drawing.Point(265, 67);
            this.tbDenNgay.Mask = "00/00/0000";
            this.tbDenNgay.Name = "tbDenNgay";
            this.tbDenNgay.Size = new System.Drawing.Size(87, 26);
            this.tbDenNgay.TabIndex = 68;
            this.tbDenNgay.ValidatingType = typeof(System.DateTime);
            this.tbDenNgay.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbDenNgay_KeyUp);
            // 
            // tbTuNgay
            // 
            this.tbTuNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbTuNgay.Location = new System.Drawing.Point(125, 67);
            this.tbTuNgay.Mask = "00/00/0000";
            this.tbTuNgay.Name = "tbTuNgay";
            this.tbTuNgay.Size = new System.Drawing.Size(87, 26);
            this.tbTuNgay.TabIndex = 67;
            this.tbTuNgay.ValidatingType = typeof(System.DateTime);
            this.tbTuNgay.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbTuNgay_KeyUp);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(223, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 20);
            this.label5.TabIndex = 66;
            this.label5.Text = "đến";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(36, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 20);
            this.label4.TabIndex = 65;
            this.label4.Text = "Từ ngày : ";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBox2.Location = new System.Drawing.Point(125, 26);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(227, 26);
            this.textBox2.TabIndex = 64;
            this.textBox2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox2_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(22, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 63;
            this.label1.Text = "Tên vật tư : ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbDienGiai);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tbSoLuong);
            this.groupBox1.Controls.Add(this.tbVatTu);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(498, 131);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(374, 229);
            this.groupBox1.TabIndex = 71;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chi tiết";
            // 
            // tbDienGiai
            // 
            this.tbDienGiai.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbDienGiai.Location = new System.Drawing.Point(129, 118);
            this.tbDienGiai.Multiline = true;
            this.tbDienGiai.Name = "tbDienGiai";
            this.tbDienGiai.ReadOnly = true;
            this.tbDienGiai.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbDienGiai.Size = new System.Drawing.Size(227, 100);
            this.tbDienGiai.TabIndex = 62;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(34, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 20);
            this.label6.TabIndex = 61;
            this.label6.Text = "Diễn giải :  ";
            // 
            // btXemBaoCao
            // 
            this.btXemBaoCao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btXemBaoCao.Location = new System.Drawing.Point(623, 373);
            this.btXemBaoCao.Name = "btXemBaoCao";
            this.btXemBaoCao.Size = new System.Drawing.Size(130, 36);
            this.btXemBaoCao.TabIndex = 73;
            this.btXemBaoCao.Text = "Xem báo cáo";
            this.btXemBaoCao.UseVisualStyleBackColor = true;
            this.btXemBaoCao.Click += new System.EventHandler(this.btXemBaoCao_Click);
            // 
            // UTDieuChuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lvTKSD);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btXemBaoCao);
            this.Name = "UTDieuChuyen";
            this.Size = new System.Drawing.Size(894, 424);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvTKSD;
        private System.Windows.Forms.TextBox tbSoLuong;
        private System.Windows.Forms.TextBox tbVatTu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MaskedTextBox tbDenNgay;
        private System.Windows.Forms.MaskedTextBox tbTuNgay;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbDienGiai;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btXemBaoCao;

    }
}
