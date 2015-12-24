namespace QuanLyKho.Design
{
    partial class UNSuDung
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
            this.lvSuDung = new System.Windows.Forms.ListView();
            this.tbTuNgay = new System.Windows.Forms.MaskedTextBox();
            this.tbNgayHoaDon = new System.Windows.Forms.Label();
            this.tbDenNgay = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbSoHoaDon = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btHoanTat = new System.Windows.Forms.Button();
            this.btChiTiet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvSuDung
            // 
            this.lvSuDung.Location = new System.Drawing.Point(14, 48);
            this.lvSuDung.Name = "lvSuDung";
            this.lvSuDung.Size = new System.Drawing.Size(864, 362);
            this.lvSuDung.TabIndex = 76;
            this.lvSuDung.UseCompatibleStateImageBehavior = false;
            this.lvSuDung.SelectedIndexChanged += new System.EventHandler(this.lvSuDung_SelectedIndexChanged);
            // 
            // tbTuNgay
            // 
            this.tbTuNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbTuNgay.Location = new System.Drawing.Point(97, 12);
            this.tbTuNgay.Mask = "00/00/0000";
            this.tbTuNgay.Name = "tbTuNgay";
            this.tbTuNgay.Size = new System.Drawing.Size(87, 26);
            this.tbTuNgay.TabIndex = 82;
            this.tbTuNgay.ValidatingType = typeof(System.DateTime);
            this.tbTuNgay.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbTuNgay_KeyUp);
            // 
            // tbNgayHoaDon
            // 
            this.tbNgayHoaDon.AutoSize = true;
            this.tbNgayHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbNgayHoaDon.Location = new System.Drawing.Point(14, 15);
            this.tbNgayHoaDon.Name = "tbNgayHoaDon";
            this.tbNgayHoaDon.Size = new System.Drawing.Size(77, 20);
            this.tbNgayHoaDon.TabIndex = 81;
            this.tbNgayHoaDon.Text = "Từ ngày : ";
            // 
            // tbDenNgay
            // 
            this.tbDenNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbDenNgay.Location = new System.Drawing.Point(285, 12);
            this.tbDenNgay.Mask = "00/00/0000";
            this.tbDenNgay.Name = "tbDenNgay";
            this.tbDenNgay.Size = new System.Drawing.Size(87, 26);
            this.tbDenNgay.TabIndex = 84;
            this.tbDenNgay.ValidatingType = typeof(System.DateTime);
            this.tbDenNgay.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbDenNgay_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(190, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 83;
            this.label1.Text = "Đến ngày : ";
            // 
            // tbSoHoaDon
            // 
            this.tbSoHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbSoHoaDon.Location = new System.Drawing.Point(487, 12);
            this.tbSoHoaDon.Name = "tbSoHoaDon";
            this.tbSoHoaDon.Size = new System.Drawing.Size(145, 26);
            this.tbSoHoaDon.TabIndex = 85;
            this.tbSoHoaDon.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbSoHoaDon_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(378, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 86;
            this.label2.Text = "Số hóa đơn : ";
            // 
            // btHoanTat
            // 
            this.btHoanTat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btHoanTat.Location = new System.Drawing.Point(772, 9);
            this.btHoanTat.Name = "btHoanTat";
            this.btHoanTat.Size = new System.Drawing.Size(106, 33);
            this.btHoanTat.TabIndex = 87;
            this.btHoanTat.Text = "Tạo mới";
            this.btHoanTat.UseVisualStyleBackColor = true;
            this.btHoanTat.Click += new System.EventHandler(this.btHoanTat_Click);
            // 
            // btChiTiet
            // 
            this.btChiTiet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btChiTiet.Location = new System.Drawing.Point(660, 9);
            this.btChiTiet.Name = "btChiTiet";
            this.btChiTiet.Size = new System.Drawing.Size(106, 33);
            this.btChiTiet.TabIndex = 88;
            this.btChiTiet.Text = "Chi tiết";
            this.btChiTiet.UseVisualStyleBackColor = true;
            this.btChiTiet.Click += new System.EventHandler(this.btChiTiet_Click);
            // 
            // UNSuDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btChiTiet);
            this.Controls.Add(this.btHoanTat);
            this.Controls.Add(this.tbSoHoaDon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbDenNgay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbTuNgay);
            this.Controls.Add(this.tbNgayHoaDon);
            this.Controls.Add(this.lvSuDung);
            this.Name = "UNSuDung";
            this.Size = new System.Drawing.Size(894, 424);
            this.Load += new System.EventHandler(this.UNHoaDon_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvSuDung;
        private System.Windows.Forms.MaskedTextBox tbTuNgay;
        private System.Windows.Forms.Label tbNgayHoaDon;
        private System.Windows.Forms.MaskedTextBox tbDenNgay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbSoHoaDon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btHoanTat;
        private System.Windows.Forms.Button btChiTiet;
    }
}
