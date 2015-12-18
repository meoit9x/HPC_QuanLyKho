namespace QuanLyKho.Design
{
    partial class UNNhuCauCT
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
            this.lvNhuCau = new System.Windows.Forms.ListView();
            this.tbNHD = new System.Windows.Forms.MaskedTextBox();
            this.tbNgayHoaDon = new System.Windows.Forms.Label();
            this.tbSoHoaDon = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btHoanTat = new System.Windows.Forms.Button();
            this.btInPhieu = new System.Windows.Forms.Button();
            this.btQuayLai = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbLoi = new System.Windows.Forms.Label();
            this.btXoa = new System.Windows.Forms.Button();
            this.btTao = new System.Windows.Forms.Button();
            this.btThoat = new System.Windows.Forms.Button();
            this.tbDienGiai = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbSoLuong = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbVatTu = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvNhuCau
            // 
            this.lvNhuCau.Location = new System.Drawing.Point(13, 14);
            this.lvNhuCau.Name = "lvNhuCau";
            this.lvNhuCau.Size = new System.Drawing.Size(472, 340);
            this.lvNhuCau.TabIndex = 9;
            this.lvNhuCau.UseCompatibleStateImageBehavior = false;
            this.lvNhuCau.SelectedIndexChanged += new System.EventHandler(this.lvNhuCau_SelectedIndexChanged);
            // 
            // tbNHD
            // 
            this.tbNHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbNHD.Location = new System.Drawing.Point(124, 377);
            this.tbNHD.Mask = "00/00/0000";
            this.tbNHD.Name = "tbNHD";
            this.tbNHD.Size = new System.Drawing.Size(87, 26);
            this.tbNHD.TabIndex = 82;
            this.tbNHD.ValidatingType = typeof(System.DateTime);
            // 
            // tbNgayHoaDon
            // 
            this.tbNgayHoaDon.AutoSize = true;
            this.tbNgayHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbNgayHoaDon.Location = new System.Drawing.Point(10, 380);
            this.tbNgayHoaDon.Name = "tbNgayHoaDon";
            this.tbNgayHoaDon.Size = new System.Drawing.Size(115, 20);
            this.tbNgayHoaDon.TabIndex = 81;
            this.tbNgayHoaDon.Text = "Thời gian cần : ";
            // 
            // tbSoHoaDon
            // 
            this.tbSoHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbSoHoaDon.Location = new System.Drawing.Point(367, 377);
            this.tbSoHoaDon.Name = "tbSoHoaDon";
            this.tbSoHoaDon.Size = new System.Drawing.Size(169, 26);
            this.tbSoHoaDon.TabIndex = 83;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(216, 380);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 20);
            this.label5.TabIndex = 84;
            this.label5.Text = "Mục đích sử dụng : ";
            // 
            // btHoanTat
            // 
            this.btHoanTat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btHoanTat.Location = new System.Drawing.Point(553, 372);
            this.btHoanTat.Name = "btHoanTat";
            this.btHoanTat.Size = new System.Drawing.Size(106, 36);
            this.btHoanTat.TabIndex = 87;
            this.btHoanTat.Text = "Gửi nhu cầu";
            this.btHoanTat.UseVisualStyleBackColor = true;
            this.btHoanTat.Click += new System.EventHandler(this.btHoanTat_Click);
            // 
            // btInPhieu
            // 
            this.btInPhieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btInPhieu.Location = new System.Drawing.Point(665, 372);
            this.btInPhieu.Name = "btInPhieu";
            this.btInPhieu.Size = new System.Drawing.Size(106, 36);
            this.btInPhieu.TabIndex = 85;
            this.btInPhieu.Text = "In phiếu";
            this.btInPhieu.UseVisualStyleBackColor = true;
            this.btInPhieu.Click += new System.EventHandler(this.btInPhieu_Click);
            // 
            // btQuayLai
            // 
            this.btQuayLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btQuayLai.Location = new System.Drawing.Point(777, 372);
            this.btQuayLai.Name = "btQuayLai";
            this.btQuayLai.Size = new System.Drawing.Size(106, 36);
            this.btQuayLai.TabIndex = 86;
            this.btQuayLai.Text = "Trở lại";
            this.btQuayLai.UseVisualStyleBackColor = true;
            this.btQuayLai.Click += new System.EventHandler(this.btQuayLai_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbLoi);
            this.groupBox1.Controls.Add(this.btXoa);
            this.groupBox1.Controls.Add(this.btTao);
            this.groupBox1.Controls.Add(this.btThoat);
            this.groupBox1.Controls.Add(this.tbDienGiai);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbSoLuong);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbVatTu);
            this.groupBox1.Location = new System.Drawing.Point(505, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(378, 340);
            this.groupBox1.TabIndex = 88;
            this.groupBox1.TabStop = false;
            // 
            // lbLoi
            // 
            this.lbLoi.AutoSize = true;
            this.lbLoi.BackColor = System.Drawing.SystemColors.Control;
            this.lbLoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbLoi.ForeColor = System.Drawing.Color.Red;
            this.lbLoi.Location = new System.Drawing.Point(13, 34);
            this.lbLoi.Name = "lbLoi";
            this.lbLoi.Size = new System.Drawing.Size(0, 17);
            this.lbLoi.TabIndex = 66;
            // 
            // btXoa
            // 
            this.btXoa.Enabled = false;
            this.btXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btXoa.Location = new System.Drawing.Point(133, 276);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(106, 36);
            this.btXoa.TabIndex = 65;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btTao
            // 
            this.btTao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btTao.Location = new System.Drawing.Point(245, 276);
            this.btTao.Name = "btTao";
            this.btTao.Size = new System.Drawing.Size(106, 36);
            this.btTao.TabIndex = 64;
            this.btTao.Text = "Tạo ";
            this.btTao.UseVisualStyleBackColor = true;
            this.btTao.Click += new System.EventHandler(this.btTao_Click_1);
            // 
            // btThoat
            // 
            this.btThoat.Enabled = false;
            this.btThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btThoat.Location = new System.Drawing.Point(21, 276);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(106, 36);
            this.btThoat.TabIndex = 63;
            this.btThoat.Text = "Thoát sửa";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click_1);
            // 
            // tbDienGiai
            // 
            this.tbDienGiai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbDienGiai.Location = new System.Drawing.Point(125, 167);
            this.tbDienGiai.Multiline = true;
            this.tbDienGiai.Name = "tbDienGiai";
            this.tbDienGiai.Size = new System.Drawing.Size(226, 88);
            this.tbDienGiai.TabIndex = 62;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(35, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 61;
            this.label1.Text = "Diễn giải : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(35, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 20);
            this.label3.TabIndex = 60;
            this.label3.Text = "Số lượng : ";
            // 
            // tbSoLuong
            // 
            this.tbSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbSoLuong.Location = new System.Drawing.Point(125, 121);
            this.tbSoLuong.Name = "tbSoLuong";
            this.tbSoLuong.Size = new System.Drawing.Size(226, 26);
            this.tbSoLuong.TabIndex = 59;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(33, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 58;
            this.label2.Text = "Mã vật tư : ";
            // 
            // tbVatTu
            // 
            this.tbVatTu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbVatTu.Location = new System.Drawing.Point(125, 73);
            this.tbVatTu.Name = "tbVatTu";
            this.tbVatTu.Size = new System.Drawing.Size(226, 26);
            this.tbVatTu.TabIndex = 57;
            // 
            // UNNhuCauCT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btHoanTat);
            this.Controls.Add(this.btInPhieu);
            this.Controls.Add(this.btQuayLai);
            this.Controls.Add(this.tbSoHoaDon);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbNHD);
            this.Controls.Add(this.tbNgayHoaDon);
            this.Controls.Add(this.lvNhuCau);
            this.Name = "UNNhuCauCT";
            this.Size = new System.Drawing.Size(894, 424);
            this.Load += new System.EventHandler(this.UNNhapNhuCau_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvNhuCau;
        private System.Windows.Forms.MaskedTextBox tbNHD;
        private System.Windows.Forms.Label tbNgayHoaDon;
        private System.Windows.Forms.TextBox tbSoHoaDon;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btHoanTat;
        private System.Windows.Forms.Button btInPhieu;
        private System.Windows.Forms.Button btQuayLai;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btTao;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.TextBox tbDienGiai;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbSoLuong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbVatTu;
        private System.Windows.Forms.Label lbLoi;
    }
}
