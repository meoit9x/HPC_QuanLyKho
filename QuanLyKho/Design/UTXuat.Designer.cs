namespace QuanLyKho.Design
{
    partial class UTXuat
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbMaySuDung = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbDenNgay = new System.Windows.Forms.MaskedTextBox();
            this.tbTuNgay = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btXemBaoCao = new System.Windows.Forms.Button();
            this.tbDienGiai = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbSoLuong = new System.Windows.Forms.TextBox();
            this.tbVatTu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbDVT = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbMaySuDung = new System.Windows.Forms.TextBox();
            this.tbHanSuDung = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvTKSD
            // 
            this.lvTKSD.Location = new System.Drawing.Point(22, 15);
            this.lvTKSD.Name = "lvTKSD";
            this.lvTKSD.Size = new System.Drawing.Size(470, 394);
            this.lvTKSD.TabIndex = 65;
            this.lvTKSD.UseCompatibleStateImageBehavior = false;
            this.lvTKSD.SelectedIndexChanged += new System.EventHandler(this.lvTKSD_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbMaySuDung);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.tbDenNgay);
            this.groupBox2.Controls.Add(this.tbTuNgay);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(498, 15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(374, 95);
            this.groupBox2.TabIndex = 67;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm kiếm";
            // 
            // cbMaySuDung
            // 
            this.cbMaySuDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbMaySuDung.FormattingEnabled = true;
            this.cbMaySuDung.Location = new System.Drawing.Point(129, 51);
            this.cbMaySuDung.Name = "cbMaySuDung";
            this.cbMaySuDung.Size = new System.Drawing.Size(226, 28);
            this.cbMaySuDung.TabIndex = 82;
            this.cbMaySuDung.SelectedIndexChanged += new System.EventHandler(this.cbMaySuDung_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(6, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 20);
            this.label7.TabIndex = 81;
            this.label7.Text = "Máy sử dụng :";
            // 
            // tbDenNgay
            // 
            this.tbDenNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbDenNgay.Location = new System.Drawing.Point(269, 19);
            this.tbDenNgay.Mask = "00/00/0000";
            this.tbDenNgay.Name = "tbDenNgay";
            this.tbDenNgay.Size = new System.Drawing.Size(86, 26);
            this.tbDenNgay.TabIndex = 68;
            this.tbDenNgay.ValidatingType = typeof(System.DateTime);
            this.tbDenNgay.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbDenNgay_KeyUp);
            // 
            // tbTuNgay
            // 
            this.tbTuNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbTuNgay.Location = new System.Drawing.Point(129, 19);
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
            this.label5.Location = new System.Drawing.Point(227, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 20);
            this.label5.TabIndex = 66;
            this.label5.Text = "đến";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(40, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 20);
            this.label4.TabIndex = 65;
            this.label4.Text = "Từ ngày : ";
            // 
            // btXemBaoCao
            // 
            this.btXemBaoCao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btXemBaoCao.Location = new System.Drawing.Point(627, 373);
            this.btXemBaoCao.Name = "btXemBaoCao";
            this.btXemBaoCao.Size = new System.Drawing.Size(130, 36);
            this.btXemBaoCao.TabIndex = 69;
            this.btXemBaoCao.Text = "Báo cáo";
            this.btXemBaoCao.UseVisualStyleBackColor = true;
            this.btXemBaoCao.Click += new System.EventHandler(this.btXemBaoCao_Click);
            // 
            // tbDienGiai
            // 
            this.tbDienGiai.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbDienGiai.Location = new System.Drawing.Point(627, 268);
            this.tbDienGiai.Multiline = true;
            this.tbDienGiai.Name = "tbDienGiai";
            this.tbDienGiai.ReadOnly = true;
            this.tbDienGiai.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbDienGiai.Size = new System.Drawing.Size(226, 91);
            this.tbDienGiai.TabIndex = 90;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(529, 268);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 20);
            this.label6.TabIndex = 89;
            this.label6.Text = "Diễn giải :  ";
            // 
            // tbSoLuong
            // 
            this.tbSoLuong.Enabled = false;
            this.tbSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbSoLuong.Location = new System.Drawing.Point(628, 156);
            this.tbSoLuong.Name = "tbSoLuong";
            this.tbSoLuong.Size = new System.Drawing.Size(86, 29);
            this.tbSoLuong.TabIndex = 88;
            // 
            // tbVatTu
            // 
            this.tbVatTu.Enabled = false;
            this.tbVatTu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbVatTu.Location = new System.Drawing.Point(628, 120);
            this.tbVatTu.Name = "tbVatTu";
            this.tbVatTu.Size = new System.Drawing.Size(225, 29);
            this.tbVatTu.TabIndex = 86;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(522, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 85;
            this.label2.Text = "Tên vật tư : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(527, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 20);
            this.label3.TabIndex = 87;
            this.label3.Text = "Số lượng : ";
            // 
            // tbDVT
            // 
            this.tbDVT.Enabled = false;
            this.tbDVT.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbDVT.Location = new System.Drawing.Point(767, 155);
            this.tbDVT.Name = "tbDVT";
            this.tbDVT.Size = new System.Drawing.Size(86, 29);
            this.tbDVT.TabIndex = 94;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(499, 200);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 20);
            this.label8.TabIndex = 95;
            this.label8.Text = "Máy sử dụng :";
            // 
            // tbMaySuDung
            // 
            this.tbMaySuDung.Enabled = false;
            this.tbMaySuDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbMaySuDung.Location = new System.Drawing.Point(628, 194);
            this.tbMaySuDung.Name = "tbMaySuDung";
            this.tbMaySuDung.Size = new System.Drawing.Size(225, 29);
            this.tbMaySuDung.TabIndex = 96;
            // 
            // tbHanSuDung
            // 
            this.tbHanSuDung.Enabled = false;
            this.tbHanSuDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbHanSuDung.Location = new System.Drawing.Point(628, 231);
            this.tbHanSuDung.Name = "tbHanSuDung";
            this.tbHanSuDung.Size = new System.Drawing.Size(85, 26);
            this.tbHanSuDung.TabIndex = 98;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(499, 234);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 97;
            this.label1.Text = "Hạn sử dụng : ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9.Location = new System.Drawing.Point(714, 234);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 20);
            this.label9.TabIndex = 99;
            this.label9.Text = "ngày";
            // 
            // UTXuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbHanSuDung);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbMaySuDung);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbDVT);
            this.Controls.Add(this.tbDienGiai);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbSoLuong);
            this.Controls.Add(this.tbVatTu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lvTKSD);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btXemBaoCao);
            this.Name = "UTXuat";
            this.Size = new System.Drawing.Size(894, 424);
            this.Load += new System.EventHandler(this.UTXuat_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvTKSD;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btXemBaoCao;
        private System.Windows.Forms.MaskedTextBox tbDenNgay;
        private System.Windows.Forms.MaskedTextBox tbTuNgay;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbMaySuDung;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbDienGiai;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbSoLuong;
        private System.Windows.Forms.TextBox tbVatTu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbDVT;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbMaySuDung;
        private System.Windows.Forms.TextBox tbHanSuDung;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
    }
}
