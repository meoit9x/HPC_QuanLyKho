namespace QuanLyKho.Design
{
    partial class TBaoCao
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
            this.cbMaySuDung = new System.Windows.Forms.ComboBox();
            this.lbMay = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbVatTu = new System.Windows.Forms.TextBox();
            this.btIn = new System.Windows.Forms.Button();
            this.btXem = new System.Windows.Forms.Button();
            this.cbBaoCao = new System.Windows.Forms.ComboBox();
            this.tbDenNgay = new System.Windows.Forms.MaskedTextBox();
            this.tbTuNgay = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbMaySuDung
            // 
            this.cbMaySuDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbMaySuDung.FormattingEnabled = true;
            this.cbMaySuDung.Location = new System.Drawing.Point(392, 149);
            this.cbMaySuDung.Name = "cbMaySuDung";
            this.cbMaySuDung.Size = new System.Drawing.Size(226, 28);
            this.cbMaySuDung.TabIndex = 129;
            // 
            // lbMay
            // 
            this.lbMay.AutoSize = true;
            this.lbMay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbMay.Location = new System.Drawing.Point(275, 151);
            this.lbMay.Name = "lbMay";
            this.lbMay.Size = new System.Drawing.Size(111, 20);
            this.lbMay.TabIndex = 128;
            this.lbMay.Text = "Máy sử dụng : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(294, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 127;
            this.label2.Text = "Tên vật tư : ";
            // 
            // tbVatTu
            // 
            this.tbVatTu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbVatTu.Location = new System.Drawing.Point(392, 193);
            this.tbVatTu.Name = "tbVatTu";
            this.tbVatTu.Size = new System.Drawing.Size(226, 26);
            this.tbVatTu.TabIndex = 126;
            // 
            // btIn
            // 
            this.btIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btIn.Location = new System.Drawing.Point(514, 282);
            this.btIn.Name = "btIn";
            this.btIn.Size = new System.Drawing.Size(106, 36);
            this.btIn.TabIndex = 125;
            this.btIn.Text = "In";
            this.btIn.UseVisualStyleBackColor = true;
            this.btIn.Click += new System.EventHandler(this.btIn_Click);
            // 
            // btXem
            // 
            this.btXem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btXem.Location = new System.Drawing.Point(392, 282);
            this.btXem.Name = "btXem";
            this.btXem.Size = new System.Drawing.Size(106, 36);
            this.btXem.TabIndex = 124;
            this.btXem.Text = "Xem ";
            this.btXem.UseVisualStyleBackColor = true;
            // 
            // cbBaoCao
            // 
            this.cbBaoCao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbBaoCao.FormattingEnabled = true;
            this.cbBaoCao.Items.AddRange(new object[] {
            "báo cáo tồn vật tư",
            "báo cáo xuất vật tư",
            "báo cáo nhập vật tư",
            "báo cáo xuất nhập tồn vật tư",
            "báo cáo sử dụng vật tư",
            "nhật ký sửa chữa tài sản"});
            this.cbBaoCao.Location = new System.Drawing.Point(512, 181);
            this.cbBaoCao.Margin = new System.Windows.Forms.Padding(4);
            this.cbBaoCao.Name = "cbBaoCao";
            this.cbBaoCao.Size = new System.Drawing.Size(228, 28);
            this.cbBaoCao.TabIndex = 123;
            this.cbBaoCao.Click += new System.EventHandler(this.cbBaoCao_SelectedIndexChanged);
            // 
            // tbDenNgay
            // 
            this.tbDenNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbDenNgay.Location = new System.Drawing.Point(533, 233);
            this.tbDenNgay.Mask = "00/00/0000";
            this.tbDenNgay.Name = "tbDenNgay";
            this.tbDenNgay.Size = new System.Drawing.Size(87, 26);
            this.tbDenNgay.TabIndex = 122;
            this.tbDenNgay.ValidatingType = typeof(System.DateTime);
            // 
            // tbTuNgay
            // 
            this.tbTuNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbTuNgay.Location = new System.Drawing.Point(393, 233);
            this.tbTuNgay.Mask = "00/00/0000";
            this.tbTuNgay.Name = "tbTuNgay";
            this.tbTuNgay.Size = new System.Drawing.Size(87, 26);
            this.tbTuNgay.TabIndex = 121;
            this.tbTuNgay.ValidatingType = typeof(System.DateTime);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(491, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 20);
            this.label5.TabIndex = 120;
            this.label5.Text = "đến";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(304, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 20);
            this.label4.TabIndex = 119;
            this.label4.Text = "Từ ngày : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(275, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 118;
            this.label1.Text = "Tên báo cáo : ";
            // 
            // TBaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbMaySuDung);
            this.Controls.Add(this.lbMay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbVatTu);
            this.Controls.Add(this.btIn);
            this.Controls.Add(this.btXem);
            this.Controls.Add(this.cbBaoCao);
            this.Controls.Add(this.tbDenNgay);
            this.Controls.Add(this.tbTuNgay);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "TBaoCao";
            this.Size = new System.Drawing.Size(894, 424);
            this.Load += new System.EventHandler(this.TBaoCao_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbMaySuDung;
        private System.Windows.Forms.Label lbMay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbVatTu;
        private System.Windows.Forms.Button btIn;
        private System.Windows.Forms.Button btXem;
        private System.Windows.Forms.ComboBox cbBaoCao;
        private System.Windows.Forms.MaskedTextBox tbDenNgay;
        private System.Windows.Forms.MaskedTextBox tbTuNgay;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;



    }
}
