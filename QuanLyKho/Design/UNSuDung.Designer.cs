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
            this.SuspendLayout();
            // 
            // lvSuDung
            // 
            this.lvSuDung.Location = new System.Drawing.Point(19, 59);
            this.lvSuDung.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lvSuDung.Name = "lvSuDung";
            this.lvSuDung.Size = new System.Drawing.Size(1151, 445);
            this.lvSuDung.TabIndex = 76;
            this.lvSuDung.UseCompatibleStateImageBehavior = false;
            this.lvSuDung.SelectedIndexChanged += new System.EventHandler(this.lvSuDung_SelectedIndexChanged);
            // 
            // tbTuNgay
            // 
            this.tbTuNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbTuNgay.Location = new System.Drawing.Point(129, 15);
            this.tbTuNgay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbTuNgay.Mask = "00/00/0000";
            this.tbTuNgay.Name = "tbTuNgay";
            this.tbTuNgay.Size = new System.Drawing.Size(115, 30);
            this.tbTuNgay.TabIndex = 82;
            this.tbTuNgay.ValidatingType = typeof(System.DateTime);
            this.tbTuNgay.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbTuNgay_KeyUp);
            // 
            // tbNgayHoaDon
            // 
            this.tbNgayHoaDon.AutoSize = true;
            this.tbNgayHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbNgayHoaDon.Location = new System.Drawing.Point(19, 18);
            this.tbNgayHoaDon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tbNgayHoaDon.Name = "tbNgayHoaDon";
            this.tbNgayHoaDon.Size = new System.Drawing.Size(100, 25);
            this.tbNgayHoaDon.TabIndex = 81;
            this.tbNgayHoaDon.Text = "Từ ngày : ";
            // 
            // tbDenNgay
            // 
            this.tbDenNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbDenNgay.Location = new System.Drawing.Point(380, 15);
            this.tbDenNgay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbDenNgay.Mask = "00/00/0000";
            this.tbDenNgay.Name = "tbDenNgay";
            this.tbDenNgay.Size = new System.Drawing.Size(115, 30);
            this.tbDenNgay.TabIndex = 84;
            this.tbDenNgay.ValidatingType = typeof(System.DateTime);
            this.tbDenNgay.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbDenNgay_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(253, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 25);
            this.label1.TabIndex = 83;
            this.label1.Text = "Đến ngày : ";
            // 
            // tbSoHoaDon
            // 
            this.tbSoHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbSoHoaDon.Location = new System.Drawing.Point(649, 15);
            this.tbSoHoaDon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbSoHoaDon.Name = "tbSoHoaDon";
            this.tbSoHoaDon.Size = new System.Drawing.Size(192, 30);
            this.tbSoHoaDon.TabIndex = 85;
            this.tbSoHoaDon.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbSoHoaDon_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(504, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 25);
            this.label2.TabIndex = 86;
            this.label2.Text = "Số hóa đơn : ";
            // 
            // btHoanTat
            // 
            this.btHoanTat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btHoanTat.Location = new System.Drawing.Point(1029, 11);
            this.btHoanTat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btHoanTat.Name = "btHoanTat";
            this.btHoanTat.Size = new System.Drawing.Size(141, 41);
            this.btHoanTat.TabIndex = 87;
            this.btHoanTat.Text = "Tạo mới";
            this.btHoanTat.UseVisualStyleBackColor = true;
            this.btHoanTat.Click += new System.EventHandler(this.btHoanTat_Click);
            // 
            // UNSuDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btHoanTat);
            this.Controls.Add(this.tbSoHoaDon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbDenNgay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbTuNgay);
            this.Controls.Add(this.tbNgayHoaDon);
            this.Controls.Add(this.lvSuDung);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UNSuDung";
            this.Size = new System.Drawing.Size(1192, 522);
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
    }
}
