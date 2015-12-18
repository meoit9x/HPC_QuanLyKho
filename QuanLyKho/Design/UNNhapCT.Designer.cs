namespace QuanLyKho.Design
{
    partial class UNNhapCT
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
            this.btHoanTat = new System.Windows.Forms.Button();
            this.tbSoHoaDon = new System.Windows.Forms.TextBox();
            this.cbKhachHang = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbLoi = new System.Windows.Forms.Label();
            this.btXuatThang = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbNHD = new System.Windows.Forms.MaskedTextBox();
            this.tbNgayHoaDon = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbSoLuong = new System.Windows.Forms.TextBox();
            this.btTao = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btThoat = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbTongTien = new System.Windows.Forms.TextBox();
            this.btXoa = new System.Windows.Forms.Button();
            this.tbVatTu = new System.Windows.Forms.TextBox();
            this.lvPhieuNhap = new System.Windows.Forms.ListView();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btHoanTat
            // 
            this.btHoanTat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btHoanTat.Location = new System.Drawing.Point(526, 370);
            this.btHoanTat.Name = "btHoanTat";
            this.btHoanTat.Size = new System.Drawing.Size(106, 36);
            this.btHoanTat.TabIndex = 82;
            this.btHoanTat.Text = "Lưu";
            this.btHoanTat.UseVisualStyleBackColor = true;
            this.btHoanTat.Click += new System.EventHandler(this.btHoanTat_Click);
            // 
            // tbSoHoaDon
            // 
            this.tbSoHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbSoHoaDon.Location = new System.Drawing.Point(112, 375);
            this.tbSoHoaDon.Name = "tbSoHoaDon";
            this.tbSoHoaDon.Size = new System.Drawing.Size(93, 26);
            this.tbSoHoaDon.TabIndex = 77;
            // 
            // cbKhachHang
            // 
            this.cbKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbKhachHang.FormattingEnabled = true;
            this.cbKhachHang.Location = new System.Drawing.Point(124, 212);
            this.cbKhachHang.Name = "cbKhachHang";
            this.cbKhachHang.Size = new System.Drawing.Size(227, 28);
            this.cbKhachHang.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(12, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 20);
            this.label4.TabIndex = 43;
            this.label4.Text = "Khách hàng : ";
            // 
            // lbLoi
            // 
            this.lbLoi.AutoSize = true;
            this.lbLoi.BackColor = System.Drawing.SystemColors.Control;
            this.lbLoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbLoi.ForeColor = System.Drawing.Color.Red;
            this.lbLoi.Location = new System.Drawing.Point(19, 19);
            this.lbLoi.Name = "lbLoi";
            this.lbLoi.Size = new System.Drawing.Size(0, 17);
            this.lbLoi.TabIndex = 41;
            // 
            // btXuatThang
            // 
            this.btXuatThang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btXuatThang.Location = new System.Drawing.Point(638, 370);
            this.btXuatThang.Name = "btXuatThang";
            this.btXuatThang.Size = new System.Drawing.Size(106, 36);
            this.btXuatThang.TabIndex = 40;
            this.btXuatThang.Text = "In phiếu";
            this.btXuatThang.UseVisualStyleBackColor = true;
            this.btXuatThang.Click += new System.EventHandler(this.btXuatThang_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(34, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 20);
            this.label3.TabIndex = 39;
            this.label3.Text = "Số lượng : ";
            // 
            // tbNHD
            // 
            this.tbNHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbNHD.Location = new System.Drawing.Point(336, 375);
            this.tbNHD.Mask = "00/00/0000";
            this.tbNHD.Name = "tbNHD";
            this.tbNHD.Size = new System.Drawing.Size(87, 26);
            this.tbNHD.TabIndex = 80;
            this.tbNHD.ValidatingType = typeof(System.DateTime);
            // 
            // tbNgayHoaDon
            // 
            this.tbNgayHoaDon.AutoSize = true;
            this.tbNgayHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbNgayHoaDon.Location = new System.Drawing.Point(211, 378);
            this.tbNgayHoaDon.Name = "tbNgayHoaDon";
            this.tbNgayHoaDon.Size = new System.Drawing.Size(119, 20);
            this.tbNgayHoaDon.TabIndex = 79;
            this.tbNgayHoaDon.Text = "Ngày hóa đơn : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(15, 378);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 78;
            this.label1.Text = "Số hóa đơn : ";
            // 
            // tbSoLuong
            // 
            this.tbSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbSoLuong.Location = new System.Drawing.Point(124, 125);
            this.tbSoLuong.Name = "tbSoLuong";
            this.tbSoLuong.Size = new System.Drawing.Size(226, 26);
            this.tbSoLuong.TabIndex = 2;
            // 
            // btTao
            // 
            this.btTao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btTao.Location = new System.Drawing.Point(236, 283);
            this.btTao.Name = "btTao";
            this.btTao.Size = new System.Drawing.Size(106, 36);
            this.btTao.TabIndex = 37;
            this.btTao.Text = "Tạo ";
            this.btTao.UseVisualStyleBackColor = true;
            this.btTao.Click += new System.EventHandler(this.btTao_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(32, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 36;
            this.label2.Text = "Mã vật tư : ";
            // 
            // btThoat
            // 
            this.btThoat.Enabled = false;
            this.btThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btThoat.Location = new System.Drawing.Point(12, 283);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(106, 36);
            this.btThoat.TabIndex = 34;
            this.btThoat.Text = "Thoát sửa";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button1.Location = new System.Drawing.Point(750, 370);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 36);
            this.button1.TabIndex = 81;
            this.button1.Text = "Trở lại";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tbTongTien);
            this.groupBox1.Controls.Add(this.btXoa);
            this.groupBox1.Controls.Add(this.cbKhachHang);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lbLoi);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbSoLuong);
            this.groupBox1.Controls.Add(this.btTao);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbVatTu);
            this.groupBox1.Controls.Add(this.btThoat);
            this.groupBox1.Location = new System.Drawing.Point(513, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(362, 343);
            this.groupBox1.TabIndex = 76;
            this.groupBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(32, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 20);
            this.label6.TabIndex = 50;
            this.label6.Text = "Tổng tiền : ";
            // 
            // tbTongTien
            // 
            this.tbTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbTongTien.Location = new System.Drawing.Point(124, 170);
            this.tbTongTien.Name = "tbTongTien";
            this.tbTongTien.Size = new System.Drawing.Size(226, 26);
            this.tbTongTien.TabIndex = 4;
            // 
            // btXoa
            // 
            this.btXoa.Enabled = false;
            this.btXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btXoa.Location = new System.Drawing.Point(124, 283);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(106, 36);
            this.btXoa.TabIndex = 48;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // tbVatTu
            // 
            this.tbVatTu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbVatTu.Location = new System.Drawing.Point(124, 81);
            this.tbVatTu.Name = "tbVatTu";
            this.tbVatTu.Size = new System.Drawing.Size(226, 26);
            this.tbVatTu.TabIndex = 1;
            // 
            // lvPhieuNhap
            // 
            this.lvPhieuNhap.Location = new System.Drawing.Point(17, 13);
            this.lvPhieuNhap.Name = "lvPhieuNhap";
            this.lvPhieuNhap.Size = new System.Drawing.Size(474, 343);
            this.lvPhieuNhap.TabIndex = 75;
            this.lvPhieuNhap.UseCompatibleStateImageBehavior = false;
            this.lvPhieuNhap.SelectedIndexChanged += new System.EventHandler(this.lvPhieuNhap_SelectedIndexChanged);
            // 
            // UNNhapVatTu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btHoanTat);
            this.Controls.Add(this.tbSoHoaDon);
            this.Controls.Add(this.tbNHD);
            this.Controls.Add(this.tbNgayHoaDon);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btXuatThang);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lvPhieuNhap);
            this.Name = "UNNhapVatTu";
            this.Size = new System.Drawing.Size(894, 424);
            this.Load += new System.EventHandler(this.UNNhapVatTu_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btHoanTat;
        private System.Windows.Forms.TextBox tbSoHoaDon;
        private System.Windows.Forms.ComboBox cbKhachHang;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbLoi;
        private System.Windows.Forms.Button btXuatThang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox tbNHD;
        private System.Windows.Forms.Label tbNgayHoaDon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbSoLuong;
        private System.Windows.Forms.Button btTao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbVatTu;
        private System.Windows.Forms.ListView lvPhieuNhap;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbTongTien;

    }
}
