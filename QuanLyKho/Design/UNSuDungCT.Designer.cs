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
            this.btHoanTat = new System.Windows.Forms.Button();
            this.tbSoHoaDon = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btXoa = new System.Windows.Forms.Button();
            this.btXuatThang = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btThoat = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tbDienGiai = new System.Windows.Forms.TextBox();
            this.lbLoi = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbSoLuong = new System.Windows.Forms.TextBox();
            this.btTao = new System.Windows.Forms.Button();
            this.tbVatTu = new System.Windows.Forms.TextBox();
            this.lvSuDung = new System.Windows.Forms.ListView();
            this.lvTonKho = new System.Windows.Forms.ListView();
            this.lbMay = new System.Windows.Forms.Label();
            this.cbMaySuDung = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btHoanTat
            // 
            this.btHoanTat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btHoanTat.Location = new System.Drawing.Point(528, 373);
            this.btHoanTat.Name = "btHoanTat";
            this.btHoanTat.Size = new System.Drawing.Size(106, 36);
            this.btHoanTat.TabIndex = 91;
            this.btHoanTat.Text = "Lưu";
            this.btHoanTat.UseVisualStyleBackColor = true;
            this.btHoanTat.Click += new System.EventHandler(this.btHoanTat_Click);
            // 
            // tbSoHoaDon
            // 
            this.tbSoHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbSoHoaDon.Location = new System.Drawing.Point(126, 378);
            this.tbSoHoaDon.Name = "tbSoHoaDon";
            this.tbSoHoaDon.Size = new System.Drawing.Size(93, 26);
            this.tbSoHoaDon.TabIndex = 86;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(17, 381);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 87;
            this.label1.Text = "Số hóa đơn : ";
            // 
            // btXoa
            // 
            this.btXoa.Enabled = false;
            this.btXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btXoa.Location = new System.Drawing.Point(407, 296);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(106, 36);
            this.btXoa.TabIndex = 48;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btXuatThang
            // 
            this.btXuatThang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btXuatThang.Location = new System.Drawing.Point(640, 373);
            this.btXuatThang.Name = "btXuatThang";
            this.btXuatThang.Size = new System.Drawing.Size(106, 36);
            this.btXuatThang.TabIndex = 83;
            this.btXuatThang.Text = "In phiếu";
            this.btXuatThang.UseVisualStyleBackColor = true;
            this.btXuatThang.Click += new System.EventHandler(this.btXuatThang_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button1.Location = new System.Drawing.Point(752, 373);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 36);
            this.button1.TabIndex = 90;
            this.button1.Text = "Trở lại";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(302, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 36;
            this.label2.Text = "Tên vật tư : ";
            // 
            // btThoat
            // 
            this.btThoat.Enabled = false;
            this.btThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btThoat.Location = new System.Drawing.Point(295, 296);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(106, 36);
            this.btThoat.TabIndex = 34;
            this.btThoat.Text = "Thoát sửa";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(309, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 20);
            this.label5.TabIndex = 50;
            this.label5.Text = "Diễn giải : ";
            // 
            // tbDienGiai
            // 
            this.tbDienGiai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbDienGiai.Location = new System.Drawing.Point(400, 195);
            this.tbDienGiai.Multiline = true;
            this.tbDienGiai.Name = "tbDienGiai";
            this.tbDienGiai.Size = new System.Drawing.Size(226, 79);
            this.tbDienGiai.TabIndex = 49;
            // 
            // lbLoi
            // 
            this.lbLoi.AutoSize = true;
            this.lbLoi.BackColor = System.Drawing.SystemColors.Control;
            this.lbLoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbLoi.ForeColor = System.Drawing.Color.Red;
            this.lbLoi.Location = new System.Drawing.Point(302, 32);
            this.lbLoi.Name = "lbLoi";
            this.lbLoi.Size = new System.Drawing.Size(0, 17);
            this.lbLoi.TabIndex = 41;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(309, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 20);
            this.label3.TabIndex = 39;
            this.label3.Text = "Số lượng : ";
            // 
            // tbSoLuong
            // 
            this.tbSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbSoLuong.Location = new System.Drawing.Point(400, 154);
            this.tbSoLuong.Name = "tbSoLuong";
            this.tbSoLuong.Size = new System.Drawing.Size(226, 26);
            this.tbSoLuong.TabIndex = 2;
            this.tbSoLuong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSoLuong_KeyPress);
            this.tbSoLuong.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbSoLuong_KeyUp);
            // 
            // btTao
            // 
            this.btTao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btTao.Location = new System.Drawing.Point(519, 296);
            this.btTao.Name = "btTao";
            this.btTao.Size = new System.Drawing.Size(106, 36);
            this.btTao.TabIndex = 37;
            this.btTao.Text = "Tạo ";
            this.btTao.UseVisualStyleBackColor = true;
            this.btTao.Click += new System.EventHandler(this.btTao_Click);
            // 
            // tbVatTu
            // 
            this.tbVatTu.Enabled = false;
            this.tbVatTu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbVatTu.Location = new System.Drawing.Point(400, 109);
            this.tbVatTu.Name = "tbVatTu";
            this.tbVatTu.Size = new System.Drawing.Size(226, 26);
            this.tbVatTu.TabIndex = 1;
            // 
            // lvSuDung
            // 
            this.lvSuDung.Location = new System.Drawing.Point(632, 18);
            this.lvSuDung.Name = "lvSuDung";
            this.lvSuDung.Size = new System.Drawing.Size(254, 336);
            this.lvSuDung.TabIndex = 84;
            this.lvSuDung.UseCompatibleStateImageBehavior = false;
            this.lvSuDung.SelectedIndexChanged += new System.EventHandler(this.lvSuDung_SelectedIndexChanged);
            // 
            // lvTonKho
            // 
            this.lvTonKho.Location = new System.Drawing.Point(0, 18);
            this.lvTonKho.Name = "lvTonKho";
            this.lvTonKho.Size = new System.Drawing.Size(268, 336);
            this.lvTonKho.TabIndex = 94;
            this.lvTonKho.UseCompatibleStateImageBehavior = false;
            this.lvTonKho.SelectedIndexChanged += new System.EventHandler(this.lvTonKho_SelectedIndexChanged);
            // 
            // lbMay
            // 
            this.lbMay.AutoSize = true;
            this.lbMay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbMay.Location = new System.Drawing.Point(283, 67);
            this.lbMay.Name = "lbMay";
            this.lbMay.Size = new System.Drawing.Size(111, 20);
            this.lbMay.TabIndex = 96;
            this.lbMay.Text = "Máy sử dụng : ";
            // 
            // cbMaySuDung
            // 
            this.cbMaySuDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbMaySuDung.FormattingEnabled = true;
            this.cbMaySuDung.Location = new System.Drawing.Point(400, 65);
            this.cbMaySuDung.Name = "cbMaySuDung";
            this.cbMaySuDung.Size = new System.Drawing.Size(226, 28);
            this.cbMaySuDung.TabIndex = 97;
            // 
            // UNSuDungCT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbMaySuDung);
            this.Controls.Add(this.lbMay);
            this.Controls.Add(this.lvTonKho);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbDienGiai);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btHoanTat);
            this.Controls.Add(this.lbLoi);
            this.Controls.Add(this.tbSoHoaDon);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbSoLuong);
            this.Controls.Add(this.btXuatThang);
            this.Controls.Add(this.btTao);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbVatTu);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.lvSuDung);
            this.Name = "UNSuDungCT";
            this.Size = new System.Drawing.Size(894, 424);
            this.Load += new System.EventHandler(this.UNSDChiTiet_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btHoanTat;
        private System.Windows.Forms.TextBox tbSoHoaDon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btXuatThang;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.Label lbLoi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbSoLuong;
        private System.Windows.Forms.Button btTao;
        private System.Windows.Forms.TextBox tbVatTu;
        private System.Windows.Forms.ListView lvSuDung;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbDienGiai;
        private System.Windows.Forms.ListView lvTonKho;
        private System.Windows.Forms.Label lbMay;
        private System.Windows.Forms.ComboBox cbMaySuDung;
    }
}
