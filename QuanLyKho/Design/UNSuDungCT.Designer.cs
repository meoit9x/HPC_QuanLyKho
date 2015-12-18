namespace QuanLyKho.Design
{
    partial class UNSuDungCT
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
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lvTonKho = new System.Windows.Forms.ListView();
            this.lbLoi = new System.Windows.Forms.Label();
            this.btSuDung = new System.Windows.Forms.Button();
            this.tbGhiChu = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbSoLuong = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbVatTu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbHanSuDung = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbMaySuDung = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbDVTNgaySD = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // tbSearch
            // 
            this.tbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbSearch.Location = new System.Drawing.Point(112, 19);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(354, 26);
            this.tbSearch.TabIndex = 8;
            this.tbSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbSearch_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(23, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tìm kiếm : ";
            // 
            // lvTonKho
            // 
            this.lvTonKho.Location = new System.Drawing.Point(21, 61);
            this.lvTonKho.Name = "lvTonKho";
            this.lvTonKho.Size = new System.Drawing.Size(445, 344);
            this.lvTonKho.TabIndex = 43;
            this.lvTonKho.UseCompatibleStateImageBehavior = false;
            this.lvTonKho.SelectedIndexChanged += new System.EventHandler(this.lvTonKho_SelectedIndexChanged);
            // 
            // lbLoi
            // 
            this.lbLoi.AutoSize = true;
            this.lbLoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbLoi.ForeColor = System.Drawing.Color.Red;
            this.lbLoi.Location = new System.Drawing.Point(514, 19);
            this.lbLoi.Name = "lbLoi";
            this.lbLoi.Size = new System.Drawing.Size(0, 20);
            this.lbLoi.TabIndex = 66;
            // 
            // btSuDung
            // 
            this.btSuDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btSuDung.Location = new System.Drawing.Point(611, 369);
            this.btSuDung.Name = "btSuDung";
            this.btSuDung.Size = new System.Drawing.Size(106, 36);
            this.btSuDung.TabIndex = 73;
            this.btSuDung.Text = "Sử dụng";
            this.btSuDung.UseVisualStyleBackColor = true;
            this.btSuDung.Click += new System.EventHandler(this.btSuDung_Click);
            // 
            // tbGhiChu
            // 
            this.tbGhiChu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbGhiChu.Location = new System.Drawing.Point(611, 239);
            this.tbGhiChu.Multiline = true;
            this.tbGhiChu.Name = "tbGhiChu";
            this.tbGhiChu.Size = new System.Drawing.Size(227, 61);
            this.tbGhiChu.TabIndex = 72;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(521, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 71;
            this.label4.Text = "Ghi chú : ";
            // 
            // tbSoLuong
            // 
            this.tbSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbSoLuong.Location = new System.Drawing.Point(611, 149);
            this.tbSoLuong.Name = "tbSoLuong";
            this.tbSoLuong.Size = new System.Drawing.Size(227, 26);
            this.tbSoLuong.TabIndex = 70;
            this.tbSoLuong.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbSoLuong_KeyUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(513, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 20);
            this.label3.TabIndex = 69;
            this.label3.Text = "Số lượng : ";
            // 
            // tbVatTu
            // 
            this.tbVatTu.Enabled = false;
            this.tbVatTu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbVatTu.Location = new System.Drawing.Point(611, 108);
            this.tbVatTu.Name = "tbVatTu";
            this.tbVatTu.Size = new System.Drawing.Size(227, 26);
            this.tbVatTu.TabIndex = 68;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(506, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 67;
            this.label2.Text = "Tên vật tư : ";
            // 
            // tbHanSuDung
            // 
            this.tbHanSuDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbHanSuDung.Location = new System.Drawing.Point(613, 321);
            this.tbHanSuDung.Name = "tbHanSuDung";
            this.tbHanSuDung.Size = new System.Drawing.Size(106, 26);
            this.tbHanSuDung.TabIndex = 78;
            this.tbHanSuDung.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbHanSuDung_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(485, 324);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 20);
            this.label6.TabIndex = 77;
            this.label6.Text = "Hạn sử dụng : ";
            // 
            // cbMaySuDung
            // 
            this.cbMaySuDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbMaySuDung.FormattingEnabled = true;
            this.cbMaySuDung.Location = new System.Drawing.Point(611, 190);
            this.cbMaySuDung.Name = "cbMaySuDung";
            this.cbMaySuDung.Size = new System.Drawing.Size(226, 28);
            this.cbMaySuDung.TabIndex = 80;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(490, 193);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 20);
            this.label7.TabIndex = 79;
            this.label7.Text = "Máy sử dụng :";
            // 
            // cbDVTNgaySD
            // 
            this.cbDVTNgaySD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbDVTNgaySD.FormattingEnabled = true;
            this.cbDVTNgaySD.Items.AddRange(new object[] {
            "Ngày",
            "Tuần ",
            "Tháng",
            "Năm"});
            this.cbDVTNgaySD.Location = new System.Drawing.Point(733, 319);
            this.cbDVTNgaySD.Name = "cbDVTNgaySD";
            this.cbDVTNgaySD.Size = new System.Drawing.Size(106, 28);
            this.cbDVTNgaySD.TabIndex = 81;
            // 
            // UNSuDungDC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbDVTNgaySD);
            this.Controls.Add(this.cbMaySuDung);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbHanSuDung);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btSuDung);
            this.Controls.Add(this.tbGhiChu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbSoLuong);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbVatTu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbLoi);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvTonKho);
            this.Name = "UNSuDungDC";
            this.Size = new System.Drawing.Size(894, 424);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lvTonKho;
        private System.Windows.Forms.Label lbLoi;
        private System.Windows.Forms.Button btSuDung;
        private System.Windows.Forms.TextBox tbGhiChu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbSoLuong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbVatTu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbHanSuDung;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbMaySuDung;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbDVTNgaySD;

    }
}
